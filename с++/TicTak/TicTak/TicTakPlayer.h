#pragma once
#include"TicTakBoard.h"
class TicTakPlayer
{
	protected:
		TicTakBoard* board;
		CellType cellType;
		string name;
public:
	TicTakPlayer();
	virtual ~TicTakPlayer();
	void SetupPlayer(string name, CellType cellType);
	void SetBoard(TicTakBoard* board);
	virtual bool MakeMove()=0;
	string GetName();
};


