#pragma once
#include"TicTakBoard.h"
#include"TicTakPlayer.h"
class TicTakManager
{
private:
	TicTakBoard* board;
	TicTakPlayer* player1;
	TicTakPlayer* player2;
	TicTakPlayer* currentPlayer;
	bool bGameFinished = false;
public:
	TicTakManager();
	virtual ~TicTakManager();
	bool Init();
	void ShowBoard();
	void MakeMove();
	bool IsGameFinished();

};
