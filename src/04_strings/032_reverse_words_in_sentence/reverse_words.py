def reverse_words(sentence):    # sentence here is an array of characters
  print(sentence)
  words = "".join(sentence).split()
  mid = len(words)//2
  i = 0

  print(words)

  while i < mid:
    tmp = words[i]
    reversed_index = len(words) - 1 - i
    words[i] = words[reversed_index]
    words[reversed_index] = tmp
    i+=1

  sentence = " ".join(words)
  print(sentence)
  return getArray(sentence)

def getArray(t):
  s = array('u', t)
  s.append('\0')
  return s