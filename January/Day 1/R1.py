n = int(input())
face = 0
polys = ["Tetrahedron", "Cube", "Octahedron", "Dodecahedron", "Icosahedron"]
faces = [4, 6, 8, 12, 20]
for i in range(n):
    p = input()
    face += faces[polys.index(p)]

print(face)
