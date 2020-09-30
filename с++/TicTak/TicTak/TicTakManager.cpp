#include "pch.h"
#include<iostream>
#include"TicTakManager.h"
#include"TicTakHumanPlayer.h"
#include"TicTakCompuerPlayer.h"



TicTakManager::TicTakManager()
{
}

TicTakManager::~TicTakManager()
{
	delete this->board;
	delete this->player1;
	delete this->player2;
}
bool TicTakManager::Init()
{
	unsigned int boardsize;
	string playerName;
	int playertype;
	cout << "введите число клеток поля(3-6):";
	cin >> boardsize;
	if ((boardsize < 3) || (boardsize > 6))
	{
		cout << "неверное число клеток поля" << endl;
		return false;
	}
	this->board = new TicTakBoard(boardsize);
	cout << "Введите тип игрока #1 (1-человк, любое другое число- Компьютер):";
		cin >> playertype;
		if (playertype == 1)
			this->player1 = new TicTakHumanPlayer();
		else
			this->player1 = new TicTakCompuerPlayer();
	cout << "Введите тип игрока #2 (1 - Человек, любое другое число - Компьютер):";
	cin >> playertype;
	if (playertype == 1)
		this->player2 = new TicTakHumanPlayer();
	else
		this->player2 = new TicTakCompuerPlayer();
	cin.ignore();
	cout << "введите имя игрока, играющего Х:";
	getline(cin, playerName);
	player1->SetupPlayer(playerName, CellType_X);
	cout << "введите имя игрока, играющего O:";
	getline(cin, playerName);
	player2->SetupPlayer(playerName, CellType_O);
	player1->SetBoard(this->board);
	player2->SetBoard(this->board);
	currentPlayer = player1;
	return true;
}
void TicTakManager::ShowBoard()
{
	this->board->Show();
}

void TicTakManager::MakeMove()
{
	ShowBoard();
	while (!currentPlayer->MakeMove())
	{
		cout << "недопустимый ход, попробуйте  еще раз" << endl;
		ShowBoard();
	}
	if (this->board->CheckEndCondition()) 
	{
		if (this->board->IsVictory())
			cout << "игрок" << currentPlayer->GetName() << "победил!" << endl;
		else
			cout << "ничья!" << endl;
		this->bGameFinished = true;
		ShowBoard();
		return;
	}
	currentPlayer = (currentPlayer == player1) ? player2 : player1;
}

bool TicTakManager::IsGameFinished()
{
	return bGameFinished;
}
