#include "pch.h"
#include "TicTakBoardMonteCarloEvaluator.h"
#include"TicTakBoard.h"
#include"TicTakRandomPlayer.h"


TicTakBoardMonteCarloEvaluator::TicTakBoardMonteCarloEvaluator(TicTakBoard* board,int numIterations,CellType startCellType,unsigned int xpos,unsigned int ypos)
{
	this->board = board;
	this->numGames = numIterations;
	this->numDraws = 0;
	this->numVictories = 0;
	this->numLosses = 0;
	this->xpos = xpos;
	this->ypos = ypos;
	this->startCellType = startCellType;
}

TicTakBoardMonteCarloEvaluator::~TicTakBoardMonteCarloEvaluator()
{
}

void TicTakBoardMonteCarloEvaluator::Evaluate()
{
	for (int i = 0; i < numGames; i++)
		EvaluateBoard();
}

void TicTakBoardMonteCarloEvaluator::EvaluateBoard()
{
	TicTakBoard* b = new TicTakBoard(this->board);
	TicTakRandomPlayer* player1 = new TicTakRandomPlayer();
	TicTakRandomPlayer* player2 = new TicTakRandomPlayer();
	TicTakRandomPlayer* currentPlayer;
	bool bGameFinished = false;
	player1->SetupPlayer("Random", CellType_X);
	player2->SetupPlayer("Random 0", CellType_O);
	player1->SetBoard(b);
	player2->SetBoard(b);
	currentPlayer = (this->startCellType == CellType_X) ? player1 : player2;
	// Checking already end condition!
	if (b->CheckEndCondition())
	{
		if (b->IsVictory())
			if (currentPlayer == player1)
				numLosses++;
			else
				numVictories++;
		else
			numDraws++;
		bGameFinished = true;
	}
	return;
	while (!bGameFinished)
	{
		while (!currentPlayer->MakeMove());
		if (b->CheckEndCondition())
		{
			if (b->IsVictory())
				if (currentPlayer == player1)
					numVictories++;
				else
					numLosses++;
			else
				numDraws++;
			bGameFinished = true;
		}
		currentPlayer = (currentPlayer == player1) ? player2 : player1;
	}
}
