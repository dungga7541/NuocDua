import pyrebase
import os
import json

config = {
    "apiKey": "AIzaSyBAbHaGULEqWOUnD4erNktFehP8Hdn3vxo",
    "authDomain": "testfire271120.firebaseapp.com",
    "databaseURL": "https://testfire271120.firebaseio.com",
    "projectId": "testfire271120",
    "storageBucket": "testfire271120.appspot.com",
    "messagingSenderId": "459870029956",
    "appId": "1:459870029956:web:3d2f9c8f0f0a2442679ad1",
    "measurementId": "G-TKNHBKF1R5",
}
firebase = pyrebase.initialize_app(config)

db = firebase.database()

from flask import *

app = Flask(__name__)

@app.route('/data', methods=['GET'])
def getApi():
	todo = db.child("name").get()
	json = todo.val()
	return json

@app.route('/', methods=['GET', 'POST'])
def basic():
	if request.method == 'POST':
		if request.form.get('submit') == 'add':

			name = request.form.get('name')
			db.child("name").push(name)
			todo = db.child("name").get()
			to = todo.val()
			return render_template('index.html', t=to.values())
		elif request.form.get('submit') == 'delete':
			db.child("name").remove()
		return render_template('index.html')
	return render_template('index.html')

if __name__ == '__main__':
	port = int(os.environ.get("PORT", 5000))
	app.run(host='0.0.0.0', port=port)