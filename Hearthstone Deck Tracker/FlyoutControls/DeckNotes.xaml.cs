﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hearthstone_Deck_Tracker.Hearthstone;

namespace Hearthstone_Deck_Tracker
{
    /// <summary>
    /// Interaction logic for DeckNotes.xaml
    /// </summary>
    public partial class DeckNotes : UserControl
    {
        private Deck currentDeck;
        public DeckNotes()
        {
            InitializeComponent();
        }

        public void SetDeck(Deck deck)
        {
            currentDeck = deck;
            Textbox.Text = deck.Note;
        }

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            currentDeck.Note = Textbox.Text;
        }
    }
}
