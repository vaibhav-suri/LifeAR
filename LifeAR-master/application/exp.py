import pyrebase

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
print(storage.child("images/1.jpeg").get_url( user['idToken']))