n = int(input())
prev = []
for i in range(n):
    curr = input()
    h = hash(curr)
    if h not in prev:
        print("NO")
        prev.append(h)
    else:
        print("YES")