#include "pch.h"
#include "TicTakBoard.h"

bool TicTakBoard::
IsRowMade(unsigned int row)
{
	int numX = 0, numO = 0;
	for (unsigned int i = 0; i < boardsize; i++)
	{
		if (cells[row][i] == CellType_O)
			numO++;
		if (cells[row][i] == CellType_X)
			numX++;
	}
	if ((numX == boardsize) || (numO == boardsize))
	{
		bVictory = true;
		return true;
	}
	return false;
}

bool TicTakBoard::IsColumnMade(unsigned int col)
{

	int numX = 0, numO = 0;
	for (unsigned int i = 0; i < boardsize; i++)
	{
		if (cells[col][i] == CellType_O)
			numO++;
		if (cells[col][i] == CellType_X)
			numX++;
	}
	if ((numX == boardsize) || (numO == boardsize))
	{
		bVictory = true;
		return true;
	}
	return false;
}

bool TicTakBoard::IsDiagMade()
{

	int numX = 0, numO = 0;
	for (unsigned int i = 0; i < boardsize; i++)
	{
		if (cells[i][i] == CellType_O)
			numO++;
		if (cells[i][i] == CellType_X)
			numX++;
	}
	if ((numX == boardsize) || (numO == boardsize))
	{
		bVictory = true;
		return true;
	}

     numX = numO = 0;
	for (unsigned int i = 0; i < boardsize; i++)
	{
		if (cells[i][boardsize-i-1] == CellType_O)
			numO++;
		if (cells[i][boardsize - i - 1] == CellType_X)
			numX++;
	}
	if ((numX == boardsize) || (numO == boardsize))
	{
		bVictory = true;
		return true;
	}
	return false;
}

bool TicTakBoard::
IsBoardFull()
{
	int numX = 0, numO = 0;
	for (unsigned int i = 0; i < boardsize; i++)
	{
		for (unsigned int j = 0; j < boardsize; j++)
		{
			if (cells[i][j] == CellType_O)
				numO++;
			if (cells[i][j] == CellType_X)
				numX++;
		}
	}
	if ((numX+numO) ==(boardsize*boardsize))
	
		return true;
	
	return false;
}

TicTakBoard::TicTakBoard(unsigned int size)
{
	this->boardsize = size;
	cells = new CellType*[size];
	for (unsigned int i = 0; i < size; i++)
		cells[i] = new CellType[size];
	for (unsigned int i = 0; i < size; i++)
		for (unsigned int j = 0; j < size; j++)
			cells[i][j] = CellType_Empty;

}

TicTakBoard::TicTakBoard(TicTakBoard * board)
{
	this->boardsize = board->boardsize;
	cells = new CellType*[boardsize];
	for(unsigned int i=0;i<boardsize;i++)
		cells[i]=new CellType[boardsize];
	for (unsigned int i = 0; i < boardsize; i++)
		for (unsigned int j = 0; j < boardsize; j++)
			cells[i][j] = board->cells[i][j];

}

TicTakBoard::~TicTakBoard()

{
	for (unsigned int i = 0; i < boardsize; i++)
		delete[]cells[i];
	delete[]cells;
}

void TicTakBoard::Show()
{
	cout << " ";
	for (unsigned int j = 0; j < boardsize; j++)
		cout << j << " ";
	cout << endl;
	for (unsigned int i = 0; i < boardsize; i++)
	{
		cout << i << " ";
		for (unsigned int j = 0; j < boardsize; j++)
		{
			switch (cells[i][j])
			{
			case CellType_X:
				cout << "X";
				break;
			case CellType_O:
				cout << "O";
					break;
			case CellType_Empty:
				cout << "-";
				break;
			}cout << "-";
		}cout << endl;

	}
}
void TicTakBoard::SetCell(unsigned int xpos, unsigned int ypos, CellType ct)
{
	cells[xpos][ypos] = ct;
}

bool TicTakBoard::CheckLegal(unsigned int xpos, unsigned int ypos)
{
	if ((xpos < 0) || (xpos > boardsize - 1) || (ypos < 0) || (ypos > boardsize - 1))
		return false;
	return (cells[ypos][xpos] == CellType_Empty);
}

bool TicTakBoard::CheckEndCondition()
{
	for (unsigned int i = 0; i < boardsize; i++)
	{
		if (IsRowMade(i) || IsColumnMade(i))
			return true;
	}
	if (IsDiagMade() || IsBoardFull())
		return true;
	return false;
}

bool TicTakBoard::IsVictory()
{
	return bVictory;
}
