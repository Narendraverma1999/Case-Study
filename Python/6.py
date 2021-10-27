'''Make a two-player Rock-Paper-Scissors game. (Hint: Ask for player plays (using input), compare
them, print out a message of congratulations to the winner, and ask if the players want to start
a new game)
Remember the rules:
 Rock beats scissors
 Scissors beats paper
 Paper beats rock'''




#Without using function

'''while True:
    user1 = input("What's your name?")
    user2 = input("And your name?")
    u1 = input("%s, do yo want to choose rock, paper or scissors?" % user1)
    u2 = input("%s, do you want to choose rock, paper or scissors?" % user2)
    if u1 == u2:
        print("It's a tie!")
        if str(input('Do you want to play another game, yes or no?\n')) == 'yes':
            continue
        else:
            print('game over.')
            break

    elif u1 == 'rock':
        if u2 == 'scissors':
            print("Rock wins!")
            if str(input('Do you want to play another game, yes or no?\n')) == 'yes':
                continue
            else:
                print('game over.')
                break
        else:
            print("invalid input")
    elif u1 == 'scissors':
        if u2 == 'paper':
            print("Scissors win!")
            if str(input('Do you want to play another game, yes or no?\n')) == 'yes':
                continue
            else:
                print('game over.')
                break
        else:
            print("invalid input")
    elif u1 == 'paper':
        if u2 == 'rock':
            print("Paper wins!")
            if str(input('Do you want to play another game, yes or no?\n')) == 'yes':
                continue
            else:
                print('game over.')
                break
        else:
            print("invalid input")

    else:
        print('invalid input')
        print('')
        if str(input('Do you want to play another game, yes or no?\n')) == 'yes':
            continue
        else:
            print('game over.')
            break'''

#using function

while True:
    choice = input("Do wanna play a game of Rock-paper-scissor? Y/N\n")
    if choice == 'Y':
        p1=input("Player 1, Enter Your Choice:")
        p2 = input("Player 2, Enter Your Choice:")

        def game(player1,player2):
            if player1 == player2:
                return("Its a tie!!!")

            elif player1 == 'rock':
                if player2 == 'scissors':
                    return("Player 1 wins\n Congrations!!!")
                else:
                    return("Player 2 wins\n Congrations!!!")
            elif player1 == 'scissors':
                if player2 == 'paper':
                    return("Player1 wins\n Congrations!!!")
                else:
                    return("Player 2 wins\n Congrations!!!")
            elif player1 == 'paper':
                if player2 == 'rock':
                    return("Player1 wins\n Congrations!!!")
                else:
                    return("Player2 wins\n Congrations!!!")
        print(game(p1, p2))

    else:
        print("game over")
    if str(input('Do you want to play another game, yes or no?\n')) == 'yes':
        continue
    else:
        print('game over.')
        break