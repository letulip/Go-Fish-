# Go Fish!

The classic card game Go Fish!
Different people play the game by slightly different rules, so here’s a recap of
the rules you’ll be using:
* The game starts with a deck of 52 cards. Five cards are dealt to each player.
The pile of cards that’s left after everyone’s dealt a hand is called the stock.
Each player takes turns asking for a value (“Do you have any sevens?”). Any
other player holding cards with that value must hand them over. If nobody has
a card with that value, then the player must “go fish” by taking a card from the
stock.
* The goal of the game is to make books, where a book is the complete set of all
four cards that have the same value. The player with the most books at the end
of the game is the winner. As soon as a player collects a book, he places it faceup
on the table so all the other players can see what books everyone else has.
* When placing a book on the table causes a player to run out of cards, then he
has to draw five more cards from the stock. If there are fewer than five cards
left in the stock, he takes all of them. The game is over as soon as the stock is
out of cards. The winner is then chosen based on whoever has the most books.
* For this computer version of Go Fish, there are two computer players and one
human player. Every round starts with the human player selecting one of the
cards in his hand, which is displayed at all times. He does this by choosing one
of the cards and indicating that he will ask for a card. Then the two computer
players will ask for their cards. The results of each round will be displayed.
This will repeat until there’s a winner.
* The game will take care of all of the trading of cards and pulling out of books
automatically. Once there’s a winner, the game is over. The game displays
the name of the winner (or winners, in case of a tie). No other action can be
taken—the player will have to restart the program in order to start a new game.
