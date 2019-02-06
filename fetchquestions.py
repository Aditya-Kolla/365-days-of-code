import re
import sys

import requests
from bs4 import BeautifulSoup

# Question urls
questionUrls = sys.argv[1:-1]
# Result file
newfile = sys.argv[-1]

questions = [requests.get(questionUrl) for questionUrl in questionUrls]
index = 1

for question in questions:
    # Parse the question
    question_soup = BeautifulSoup(question.text, 'html.parser')
    # Problem format
    problem = str(index) + '. ' + question_soup.find('div', {'class': 'title'}).text[3:] + '\n' + question.url + '\n' \
        + 'Time Limit: ' + question_soup.find('div', {'class': 'time-limit'}).contents[1] + '\n' \
        + 'Memory Limit: ' + question_soup.find('div', {'class': 'memory-limit'}).contents[1] + '\n' \
        + 'Input: ' + question_soup.find('div', {'class': 'input-file'}).contents[1] + '\n' \
        + 'Output: ' + question_soup.find('div', {'class': 'output-file'}).contents[1] + '\n' \
        + 'Rating: ' + \
        re.sub(r'\r|\n|\s|[*]', '', question_soup.find('span',
                                                       {'title': 'Difficulty'}).text) + '\n'
    # Write to file
    with open(newfile, 'a') as problems:
        problems.write(problem + '\n')
    index += 1
