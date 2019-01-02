input()
games = input()
anton = games.count('A')
danik = len(games) - anton
print(("Anton") if (anton > danik) else ("Danik") if danik > anton else ("Friendship"))