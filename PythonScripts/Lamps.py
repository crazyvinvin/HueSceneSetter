from logging import NullHandler
from colorsys import rgb_to_hsv
from threading import Thread
import random
import time
import phue
import sys

b = phue.Bridge('192.168.42.30')
b.connect()
lights = b.lights
groups = b.groups

def animation(lightName, RGB, repeat=1, transitionTime=0):
    HSV = rgb_to_hsv(RGB[0]/255, RGB[1]/255,RGB[2]/255)
    H, S, V = round(HSV[0] * 65534), round(HSV[1] * 254), round(HSV[2]*254)
    print(H, S ,V)

    for i in range(repeat):
        command = {
            'transitiontime': transitionTime, 
            'on': True, 
            'hue': H, 
            'sat': S, 
            'bri': V
        }

        b.set_light(lightName, command)
        time.sleep(random.uniform(0.01, 0.5))
        
        command = {
         'transitiontime': transitionTime, 
         'on': False}
        b.set_light(lightName, command)
        time.sleep(random.uniform(0.01, 0.5))

def addLightAnimation(lightName, RGB, repeat, transitionTime):
    LightAnimations = []
    lightAnimationThread = Thread(target=animation, args=(lightName, RGB, repeat, transitionTime))
    LightAnimations.append(lightAnimationThread)
    return LightAnimations


def getThreadsArray():
    threads = []
    RGB = [47, 102, 44]
    thread1 = Thread(target=animation, args=('Ledstrip Vincents Gamehok', RGB, 100, 0))
    threads.append(thread1) 
    return threads

threads = getThreadsArray()
for thread in threads:
    thread.start()



    


