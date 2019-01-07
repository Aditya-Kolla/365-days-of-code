st = input().split(' ')
days, limit = int(st[0]), int(st[1])
names = [int(i) for i in input().split(' ')]
written = 0
for d in range(days):
    written += names[d] # write all the names for the day
    # flips = number of names written/ limit per page
    print(int(written/limit), end=' ')
    # denotes number of names written in the last written page
    # Example 2: written = 38%20 = 18 => [20, 18]
    # took help for this
    written %= limit
