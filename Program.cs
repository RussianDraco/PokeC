/*
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program {
    static List<PokeCard> cards = new List<PokeCard>();
    const string jsonPath = "cards.json";

    static void Main() {
        LoadCards();
        while (true) {
            
        }
    }

    static void LoadCards() {
        if (File.Exists(jsonPath)) {
            string json = File.ReadAllText(jsonPath);
            cards = JsonConvert.DeserializeObject<List<PokeCard>>(json);
        }
    }
}
**/