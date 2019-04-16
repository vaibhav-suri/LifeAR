import pyrebase
import urllib
import cv2
import numpy as np
from keras.models import model_from_json   
import numpy
import cv2
from keras.preprocessing import image
config = {
  "apiKey": "AIzaSyDtpqE2Ne-htEyMBxObFj_H0Y6XsF9LInk",
  "authDomain": "gauri-ab979.firebaseapp.com",
  "databaseURL": "https://gauri-ab979.firebaseio.com",
  "storageBucket": "gauri-ab979.appspot.com"
}

firebase = pyrebase.initialize_app(config)
auth = firebase.auth()

user = auth.sign_in_with_email_and_password("g.kalyan04@gmail.com", "123456789")
storage = firebase.storage()

path = "1.jpeg"
json_file = open('model.json', 'r')
model_json = json_file.read()
model = model_from_json(model_json)
model.load_weights("model.h5")
img_width = 64
img_height = 64
img = cv2.imread(path)
img = cv2.resize(img,(64,64),3)
img = img.reshape((-1, 64, 64, 3))

#test_image= image.load_img(picturePath, target_size = (img_width, img_height)) 
#test_image = image.img_to_array(test_image)
#test_image = numpy.expand_dims(test_image, axis = 0)
#test_image = test_image.reshape(img_width, img_height)
result = model.predict(img)
if (result[0][0]==1.0):
    print("Pneumonia")
else:
    print("Normal")