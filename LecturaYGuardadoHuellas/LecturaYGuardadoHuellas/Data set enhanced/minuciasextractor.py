import cv2
import fingerprint_feature_extractor

def getPathandIteration(path,iteration):
    return path,iteration
if __name__ == '__main__':
    for iteracion in range(1,11):
        img_name = 'h'+ str(iteracion)+'.bmp'
        path = 'LecturaYGuardadoHuellas\\LecturaYGuardadoHuellas\\Data set enhanced\\Yvonne\\'
        path_save = 'LecturaYGuardadoHuellas\\LecturaYGuardadoHuellas\\Features\\Yvonne\\'
        img = cv2.imread(path+img_name, 0)				# read the input image --> You can enhance the fingerprint image using the "fingerprint_enhancer" library
        FeaturesTerminations, FeaturesBifurcations = fingerprint_feature_extractor.extract_minutiae_features(img, path_save+img_name, iteracion,showResult=True)
        