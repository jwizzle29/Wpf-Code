# Wpf-Code
Full MVVM WPF software
This is a simple BlackJack game written in WPF using the MVVM architecture.
There are 3 ViewModels(VM's) that are included, BlackJackVM,DealerVM,and PlayerVM.
The Dealer and player ViewModel's are controlled by the BlackJack View Model. 
BlackJackVM acts as a control VM and it also controls access to both User Controls(PlayerUC, and DealerUC) 
through the PlayerVM and DealerVM respectively.
There are a few classes included, such as GameDeck which controls the Deck used 
in the game, and there is a Card class from which the deck is built upon. 
This project uses the DelegateCommand class to delegate methods so there
is no code behind in any files aside from initializeComponent();
Simply click start game to unlock the screen and you will be dealt two cards. 
