# Welcome to Simple Serial Code – game activation system

**I will show you how to setup everything step by step!**

# Step 1

Import everything to your project! <br>
From release: 

# Step 2

Go to **Serial code protection** > **Scenes**

Add “ **EnterKey** ” scene on the top in **Build settings** (Ctrl + shift + B) and open this scene.
<img src="https://github.com/nibek1000/Serial-code-protection-for-Unity3d/blob/main/Pictures/image--000.jpg?raw=true">
# Step 3

Show your project in explorer and upload to your **FTP server** all files from “ **UploadThis** ”
folder.
<img src="https://github.com/nibek1000/Serial-code-protection-for-Unity3d/blob/main/Pictures/image--001.jpg?raw=true">

# Step 4.1 – if you have FTP server

Edit **index.php** just with **your server information**.

If you will keep **codes.txt** in the same folder as **index.php** , you don’t need to change **$file**.
You still need to change **$url**. It should end with **/index.php**. For example if you keep files in
public folder (main) enter [http://www.yourDomain.com/index.php](http://www.yourDomain.com/index.php)
<img src="https://github.com/nibek1000/Serial-code-protection-for-Unity3d/blob/main/Pictures/image--002.jpg?raw=true">
Now you should be able to open **index.php** file and use it. Here you can modify, remove and
add new serial keys. Feel free to use generated one on the top.
<img src="https://github.com/nibek1000/Serial-code-protection-for-Unity3d/blob/main/Pictures/image--003.jpg?raw=true">

# Step 4.2 – if you don’t have FTP server


If you don’t have **FTP server** you can use any website with text editor to make codes
database. We recommend you to use **PasteBin.com**. You can later **edit** codes.
Create an account and make new Paste, enter in it codes you want to be active (separate
them with **ONE** spacebar).
<img src="https://github.com/nibek1000/Serial-code-protection-for-Unity3d/blob/main/Pictures/image--004.png?raw=true">

**Create paste** and get link to **RAW** version.
<img src="https://github.com/nibek1000/Serial-code-protection-for-Unity3d/blob/main/Pictures/image--005.png?raw=true">


Enter link to **RAW** version in **URL string**.
<img src="https://github.com/nibek1000/Serial-code-protection-for-Unity3d/blob/main/Pictures/image--006.png?raw=true">
<img src="https://github.com/nibek1000/Serial-code-protection-for-Unity3d/blob/main/Pictures/image--007.png?raw=true"><br>
# Step 5

**Enter URL** to **codes.txt** in **Main** (gameobject) > **Protect** (script)
<img src="https://github.com/nibek1000/Serial-code-protection-for-Unity3d/blob/main/Pictures/image--008.jpg?raw=true">

# Step 6

Change **secret key** in **Serial code protection** > **Scripts** > **Encryptor** (script). Make it long and
hard to remember.
<img src="https://github.com/nibek1000/Serial-code-protection-for-Unity3d/blob/main/Pictures/image--012.jpg?raw=true">
<img src="https://github.com/nibek1000/Serial-code-protection-for-Unity3d/blob/main/Pictures/image--013.jpg?raw=true">
# Step 7

Make sure that in **Main** (gameObject) > **Protect** (script) there is nothing missing and **Activate
button** has **script connected**.
<img src="https://github.com/nibek1000/Serial-code-protection-for-Unity3d/blob/main/Pictures/image--009.jpg?raw=true">

If you need any help write on my email:

support@yellowsink.pl


