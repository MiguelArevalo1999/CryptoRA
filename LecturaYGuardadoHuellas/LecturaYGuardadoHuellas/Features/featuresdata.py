import csv
with open("LecturaYGuardadoHuellas\LecturaYGuardadoHuellas\Features\Miguel_features.txt","r") as f:
    lines = f.read().split("\n")
    f.close()
    print(lines)