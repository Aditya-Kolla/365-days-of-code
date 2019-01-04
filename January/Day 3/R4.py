n = int(input())
contestants = [int(i) for i in input().split(' ')]
contestants.sort(reverse=True)
if n <= 25 and contestants[0] > 25: print(contestants[0] - 25)
else: print(0)