def remove_duplicates(str):

    result = ""
    uniq_charactres = set()

    for ch in str:
        if ch not in uniq_charactres:
            uniq_charactres.add(ch)
            result += ch

    result = getArray(result)
    print(result)
    return result

def getArray(t):
  s = array('u', t)
  s.append('\0')
  return s