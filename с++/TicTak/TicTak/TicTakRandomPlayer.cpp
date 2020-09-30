#include "pch.h"
#include "TicTakRandomPlayer.h"
#include"TicTakBoard.h"
TicTakRandomPlayer::TicTakRandomPlayer()
{
}

TicTakRandomPlayer::~TicTakRandomPlayer()
{
}

bool TicTakRandomPlayer::MakeMove()
{
	unsigned int row, col;
	row = this->board->GetSize();
	col = this->board->GetSize();
		if (this->board->CheckLegal(col, row))
		{
			this->board->SetCell(col, row, this->cellType);
			return true;
		}
	return false;
}
