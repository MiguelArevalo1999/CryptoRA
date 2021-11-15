import sys
from FingerprintImageEnhancer import FingerprintImageEnhancer
import cv2

if __name__ == '__main__':

    # for iteracion in range(1,11):
        image_enhancer = FingerprintImageEnhancer()         # Create object called image_enhancer
        if(len(sys.argv)<2):                                # load input image
            print('loading sample image')
            img_name = 'h8.bmp'#+ str(iteracion)+'.bmp'
            img = cv2.imread("LecturaYGuardadoHuellas\\LecturaYGuardadoHuellas\\Data set\\Miguel\\"+img_name)
            
        elif(len(sys.argv) >= 2):
            img_name = sys.argv[1]
            img = cv2.imread('../images/' + img_name)

        if(len(img.shape)>2):                               # convert image into gray if necessary
            img = cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)

        out = image_enhancer.enhance(img)     # run image enhancer
        #image_enhancer.save_enhanced_image("LecturaYGuardadoHuellas\\LecturaYGuardadoHuellas\\Data set enhanced\\Yvonne\\" + img_name)   # save output