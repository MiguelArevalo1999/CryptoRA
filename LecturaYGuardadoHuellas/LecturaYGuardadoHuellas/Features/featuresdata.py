import csv
with open("LecturaYGuardadoHuellas\LecturaYGuardadoHuellas\Features\Miguel_features.txt","r") as f:
    lst=f.read()
    f.close()
    list_of_lines = lst.split("\n")
print(list_of_lines)