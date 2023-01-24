using CharacterGeneratorRPG;

Character firstChar = new Character();

//The method is static, so it runs on the class and not the object
firstChar.CharacterClass = Character.GetCharacterClassRandomly();
firstChar.CharacterStats.GetRolled();
firstChar.CharacterStats.Dexterity = 1;
firstChar.Race = "High Elf";
firstChar.Level = 99;
firstChar.Birthday = new DateTime(500, 2, 1);
Console.WriteLine("Race: " + firstChar.Race);
Console.WriteLine("Level: " + firstChar.Level);
Console.WriteLine("Age: " + firstChar.Birthday);
Console.WriteLine(firstChar.Name);