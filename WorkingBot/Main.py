import nltk
from nltk.stem.lankaster import LancasterStemmer
Stemmer = LancasterStemmer()

import numpy as np
import tflearn
import tenserflow
import random
import json

with open("Diction.json") as file:
    data = json.load(file)
    
words = []
labels = []
docs = []

for intent in data["Diction"]:
    for pattern in intent["Patterns"]:
        words = nltk.word_tokenize(pattern)
        words.extend(words)
        docs.append(pattern)
        
        if intent["tag"] not in labels:
            labels.append(intent["tag"])