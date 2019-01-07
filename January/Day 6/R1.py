t = int(input())

charset = "abcdefghijklmnopqrstuvwxyz"

while t > 0:
    st = input().split(' ')
    n, k = int(st[0]), int(st[1])
    minimimum_freq = int(n/k)
    query = charset[:k]*minimimum_freq
    len_query = len(query)
    if len_query < n:
        query += charset[0]*(n - len_query)
    print(query)
    t -= 1
