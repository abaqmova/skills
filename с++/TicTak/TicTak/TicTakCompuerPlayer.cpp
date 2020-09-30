#include "pch.h"
#include "TicTakCompuerPlayer.h"
#include"TicTakBoardMonteCarloEvaluator.h"

TicTakCompuerPlayer::TicTakCompuerPlayer()
{
}

TicTakCompuerPlayer::~TicTakCompuerPlayer()
{
}

bool TicTakCompuerPlayer::MakeMove()
{
	vector <TicTakBoardMonteCarloEvaluator*> evaluators;
	for (unsigned int i = 0; i < 6; i++)
		for (unsigned int j = 0; j < 6; j++)
			if (this->board->CheckLegal(j, i))
			{
				this->board->SetCell(j, i, this->cellType);
				evaluators.push_back(new TicTakBoardMonteCarloEvaluator(this->board, 1000, (this->cellType == CellType_X) ? CellType_O : CellType_X, j, i));
				this->board->SetCell(j, i, CellType_Empty);
			}
	for (auto evaluator = evaluators.begin(); evaluator != evaluators.end(); evaluator++)
		(*evaluator)->Evaluate();
	int biggestVictories = -1;
	for (auto evaluator = evaluators.begin(); evaluator != evaluators.end(); evaluator++)
		if (this->cellType == CellType_X)
		{
			if ((*evaluator)->GetVictories() > biggestVictories)
				biggestVictories = (*evaluator)->GetVictories();
		}
		else
		{
			if ((*evaluator)->GetLosses() > biggestVictories)
				biggestVictories = (*evaluator)->GetLosses();
		}
	vector<TicTakBoardMonteCarloEvaluator*> biggestWinEvaluators;
	for (auto evaluator = evaluators.begin(); evaluator != evaluators.end(); evaluator++)
	{
		int numVictories;
		if (this->cellType == CellType_X)
			numVictories = (*evaluator)->GetVictories();
		else
			numVictories = (*evaluator)->GetLosses();
		if (numVictories == biggestVictories)
			biggestWinEvaluators.push_back((*evaluator));
	}
	this->board->SetCell(biggestWinEvaluators[0]->Getxpos(), biggestWinEvaluators[0]->Getypos(), this->cellType);
					for (auto evaluator =evaluators.begin(); evaluator != evaluators.end(); evaluator++)
						delete(*evaluator);
					evaluators.clear();
					biggestWinEvaluators.clear();
							return true;
}
