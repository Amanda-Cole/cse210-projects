using System;

public class Library
{
    List<string> _Library = new List<string>();
    private string _fullScripture;

    public Library(){
        _Library.Add("Alma/32/21/0/ And now as I said concerning faith - faith is not to have a perfect knowledge of things; thereforeif ye have faith ye hope for things which are not seen, which are true.");
        _Library.Add("1 Nephi/3/7/0/ And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. ");
        _Library.Add("1 Nephi/1/9/10/ And it came to pass that he saw One descending out of the midst of heaven, and he beheld that his luster was above that of the sun at noon-day.; And he also saw twelve others following him, and their brightness did exceed that of the stars in the firmament.");
        _Library.Add("Helaman/5/12/0/ And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");
        _Library.Add("Isaiah/41/10/0/ Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness.");
        _Library.Add("Proverbs/3/5/6/ Trust in the Lord with all thine heart; and lean not unto thine own understanding.; In all thy ways acknowledge him, and he shall direct thy paths.");
    }
        // string _fullVerse = "";
    public string getScripture(string choice){

        if (choice == "LEHI"){
            _fullScripture = _Library[2];
        }
        if (choice == "NEPHI"){
            _fullScripture = _Library[1];
        }
        if (choice == "ALMA"){
            _fullScripture = _Library[0];
        }
        if (choice == "HELAMAN"){
            _fullScripture = _Library[3];
        }
        if (choice == "ISAIAH"){
            _fullScripture = _Library [4];
        }        
        if (choice == "PROVERBS"){
            _fullScripture = _Library [5];
        }
        return _fullScripture;
    }    
}