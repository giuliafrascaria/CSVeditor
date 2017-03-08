import csv
import datetime
import os
import re

generalCSV = open('reservations.csv')
singlelineCSV = open('singleline.csv', 'wt')

try:

    readerFile = csv.reader(generalCSV)
    csvWriter = csv.writer(singlelineCSV)
    dataList = list(readerFile)
    j = 1
    for i in range(2, len(dataList)):
        row = dataList[i]
        if len(row) <= 10:
            print(str(j) + "j")
            prevrow = dataList[i - j]
            smallrow = dataList[i]
            if len(smallrow) == 1:
                #fila contenente solo una materia, la aggiungo all'ultima cella
                prevrow[-1] = prevrow[-1] + " " + smallrow[0]
            else:
                #fila contenente una materia e un professore
                prevrow[-1] = prevrow[-1] + " " + smallrow[0]
                professor = smallrow[1]
                print(professor)
                prevrow.append(professor)
            print("riga corta, metto nella riga precedente")
            #vado avanti di una riga iterando il ciclo for
            j += 1  #ma mi segno che devo incollare tutto una riga piu indietro
        else:
            csvWriter.writerow(dataList[i - j])
            print("riga lunga, scrivo")
            j = 1
            #print(row)
            #copio la riga nel csv corretto
            #print("row normale")
finally:
    generalCSV.close()


with open('singleline.csv', 'r') as fdin, open('out.csv', 'wt') as fdout:
    for line in csv.reader(fdin):
        # insert into each row by index
        if len(line) < 13:
            line.insert(11, '')
        # and write
        csv.writer(fdout).writerow(line)

os.remove("singleline.csv")


source = open('out.csv')
result = open('result.csv', 'wt')


try:
    rdr = csv.reader(source)
    wtr = csv.writer(result)
    for r in rdr:
        mylist = r[4].split(" ")
        durata = r[6].split(" ")
        print("giorno " + mylist[0] + " ora di inizio " + mylist[1] + " durata " + durata[0])
        d = datetime.datetime.strptime(mylist[0], '%d/%m/%Y').strftime('%a')
        print(d)
        i = 0
        if mylist[1] == "08:30":
            i = 0
        if mylist[1] == "09:30":
            i = 1
        if mylist[1] == "10:30":
            i = 2
        if mylist[1] == "11:30":
            i = 3
        if mylist[1] == "12:30":
            i = 4
        if mylist[1] == "13:15":
            i = 5
        if mylist[1] == "14:00":
            i = 6
        if mylist[1] == "15:00":
            i = 7
        if mylist[1] == "16:00":
            i = 8
        if mylist[1] == "17:00":
            i = 9
        if d == "Mon":
            i += 0
        if d == "Tue":
            i += 10
        if d == "Wed":
            i += 20
        if d == "Thu":
            i += 30
        if d == "Fri":
            i += 40
        wtr.writerow((i, r[1], r[2], r[3], r[10], r[11]))

        if durata[0] == "2":
            #devo dividere lo slot in due righe csv
            print("devo aggiungere una row perche durava due ore")
            wtr.writerow((i+1, r[1], r[2], r[3], r[10], r[11]))
        elif len(durata) == 4:
            print("devo aggiungere una row perche durava una e 45")
            wtr.writerow((i + 1, r[1], r[2], r[3], r[10], r[11]))
finally:
    source.close()
    result.close()


source = open('result.csv')
result = open('result2.csv', 'wt')


try:
    rdr = csv.reader(source)
    wtr = csv.writer(result)
    for r in rdr:
        courselist = re.split(' ano| anno| year', r[4])
        courselist.pop(-1)

        print(courselist)
        codeCell = ""

        for x in courselist:
            coursecode = ""
            if "gestionale" in x:
                coursecode += "01"
            elif "energetica" in x:
                coursecode += "02"
            elif "meccanica" in x:
                coursecode += "03"
            elif "medica" in x:
                coursecode += "04"
            elif "civile e ambientale" in x:
                coursecode += "05"
            elif "sciences" in x:
                coursecode += "06"
            elif "edilizia" in x:
                coursecode += "07"
            elif "architettura" in x:
                coursecode += "08"
            elif "elettronica" in x:
                coursecode += "09"
            elif "di internet" in x:
                coursecode += "10"
            elif "informatica" in x:
                coursecode += "11"
            elif "ICT" in x:
                coursecode += "23"
            elif "automazione" in x:
                coursecode += "13"
            elif "civile" in x:
                coursecode += "14"
            elif "tecniche" in x:
                coursecode += "15"
            elif "territorio" in x:
                coursecode += "16"
                #anno di corso
            if "magistrale I" in x:
                coursecode += "4"
            elif "magistrale II" in x:
                coursecode += "5"
            elif "III" in x:
                coursecode += "3"
            elif "II" in x:
                coursecode += "2"
            elif "I" in x:
                coursecode += "1"

            codeCell = codeCell + coursecode + " "

        wtr.writerow((r[0], r[1], r[2], r[3], r[4], r[5], codeCell))

finally:
    source.close()
    result.close()


# with open('result.csv', 'r') as fdin, open('final.csv', 'wt') as fdout:
#     for line in csv.reader(fdin):
#         # insert into each row by
#         if len(line) == 5:
#             print(line)
#             #line.insert(11, '')
#         # and write
#         csv.writer(fdout).writerow(line)
#os.remove("out.csv")

def levenshtein_distance(s1, s2):
    if len(s1) > len(s2):
        s1, s2 = s2, s1

    distances = range(len(s1) + 1)
    for i2, c2 in enumerate(s2):
        distances_ = [i2+1]
        for i1, c1 in enumerate(s1):
            if c1 == c2:
                distances_.append(distances[i1])
            else:
                distances_.append(1 + min((distances[i1], distances[i1 + 1], distances_[-1])))
        distances = distances_
    return distances[-1]
