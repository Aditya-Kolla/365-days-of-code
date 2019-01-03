input()
cards = [int(i) for i in input().split(" ")]
s = 0
d = 0
turn = 0
while len(cards) != 0:
    pick = cards[0] if cards[0] > cards[-1] else cards[-1]
    cards.remove(pick)
    if turn % 2 == 0: s += pick
    else: d += pick
    turn += 1
print(s,d)