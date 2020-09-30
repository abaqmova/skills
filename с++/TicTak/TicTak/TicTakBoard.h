#pragma once
#include"CellType.h"
class TicTakBoard
{
private:
	unsigned int boardsize;
	CellType**cells;
	bool bVictory = false;
	bool IsRowMade(unsigned int row);
	bool IsColumnMade(unsigned int col);
	bool IsDiagMade();
	bool IsBoardFull();
public:
	int GetSize() { unsigned int boardsize; };
	TicTakBoard(unsigned int size);
	TicTakBoard(TicTakBoard* board);
	virtual ~TicTakBoard();
	void Show();
	void SetCell(unsigned int xpos, unsigned int ypos, CellType ct);
	bool CheckLegal(unsigned int xpos, unsigned int ypos);
	bool CheckEndCondition();
	bool IsVictory();

};