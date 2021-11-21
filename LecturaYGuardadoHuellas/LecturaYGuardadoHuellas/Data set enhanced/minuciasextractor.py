import cv2
import fingerprint_feature_extractor


if __name__ == '__main__':
    for iteracion in range(1,11):
        img = cv2.imread('LecturaYGuardadoHuellas\LecturaYGuardadoHuellas\Data set enhanced\Yvonne\\h'+str(iteracion)+'.bmp', 0)				# read the input image --> You can enhance the fingerprint image using the "fingerprint_enhancer" library
        FeaturesTerminations, FeaturesBifurcations = fingerprint_feature_extractor.extract_minutiae_features(img, showResult=True)