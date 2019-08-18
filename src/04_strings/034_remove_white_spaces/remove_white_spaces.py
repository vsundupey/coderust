from __future__ import print_function
from array import array

def remove_white_spaces(s):
    read_index = 0
    write_index = 0
  
    while read_index < len(s):
      while s[read_index] != '\t' and s[read_index] != ' ':
        write_index+=1;
        read_index+=1;
  
      while s[read_index] == '\t' or s[read_index] == ' ':
        read_index += 1;
  
      s[write_index] = s[read_index];
  
    return s[:write_index]

def getArray(t):
    s = array('u', t)
    s.append('\0')
    return s

sentences = remove_white_spaces(getArray("Hello wor ld!"))
print(sentences)