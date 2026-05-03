// Projet : SecurIT_Logic
using SecurIT_Logic;
using System;
using System.Collections.Generic;

public class GameManager
{
    public List<Card> Cartes { get; private set; }
    public int Essais { get; private set; }

    // Événements pour prévenir l'UI que quelque chose s'est passé
    public Action<Card, Card> OnPaireTrouvee;
    public Action<Card, Card> OnPaireRatee;
    public Action OnVictoire;

    public GameManager(int nombreDePaires)
    {
        // Génération et mélange des cartes (que des données, pas de visuel)
    }

    public void JouerCarte(Card carteCliquee)
    {
        // 1. Vérifie si on peut jouer
        // 2. Compare les deux cartes
        // 3. Déclenche OnPaireTrouvee ou OnPaireRatee
        // 4. Vérifie si le jeu est fini et déclenche OnVictoire
    }
}