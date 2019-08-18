from __future__ import print_function
import sys, os, time

def can_segment_string(s, dict):
      existing_words = []
      count_length = 0

      for word in dict:            
            if s.find(word) != -1:
                  existing_words.append(word)

      if len(existing_words) == 0:
            return False

      for word in existing_words:
            count_length += len(word)

      if count_length == len(s):
            return True
      else:
            return False



def main():
  s = "applepie";
  dict = set(["pie","pear","apple","peach"])
  if can_segment_string(s, dict):
    print("can break.")
  else:
    print("can't break.")

main()  