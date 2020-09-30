#include "pch.h"
#include "TicTakPlayer.h"

TicTakPlayer::TicTakPlayer()
{
}

TicTakPlayer::~TicTakPlayer()
{
}

void TicTakPlayer::SetupPlayer(string name, CellType cellType)
{
	this->name = name;
	this->cellType = cellType;
}

void TicTakPlayer::SetBoard(TicTakBoard * board)
{
	this->board = board;
}

string TicTakPlayer::GetName()
{
	return this->name;
}
