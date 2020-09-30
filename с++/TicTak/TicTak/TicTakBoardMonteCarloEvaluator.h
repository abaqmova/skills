#pragma once
#include"TicTakBoard.h"
class TicTakBoardMonteCarloEvaluator
{
private:
	TicTakBoard* board;
	int numGames;
	int numVictories;
	int numLosses;
	int numDraws;
	unsigned int xpos, ypos;
	CellType startCellType;
public:
	TicTakBoardMonteCarloEvaluator(TicTakBoard * board, int numIterations, CellType startCellType, unsigned int xpos, unsigned int ypos);
	~TicTakBoardMonteCarloEvaluator();
	void Evaluate();
	void EvaluateBoard();
	int GetVictories( ){return numVictories; }
	int GetLosses() { return numLosses; }
	int GetDraws() { return numGames; }
	int Getxpos() { return xpos; }
	int Getypos() { return ypos; }


};

