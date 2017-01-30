import csv
import datetime

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
            prevrow.extend(smallrow)
            print("riga corta, metto nella riga precedente")
            #pr
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

source = open('singleline.csv')
result = open('result.csv', 'wt')

try:
    rdr = csv.reader(source)
    wtr = csv.writer(result)
    for r in rdr:
        mylist = r[4].split(" ")
        print("giorno " + mylist[0] + " ora di inizio " + mylist[1])
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
finally:
    source.close()
    result.close()
