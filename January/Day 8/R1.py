input()

sequence = [int(i) for i in input().split(' ')]
sequence.sort()
a, b = sequence[-2] - sequence[0], sequence[-1] - sequence[1]
print(a) if a < b else print(b)