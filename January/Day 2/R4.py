input()
seq = [int(i) for i in input().split(" ")]
b = 0
c = 0
for s in seq:
    if s >= 0: b += s
    else: c += s
print(b-c)