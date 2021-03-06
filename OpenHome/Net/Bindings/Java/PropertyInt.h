/* DO NOT EDIT THIS FILE - it is machine generated */
#include <jni.h>
/* Header for class org_openhome_net_core_PropertyInt */

#ifndef _Included_org_openhome_net_core_PropertyInt
#define _Included_org_openhome_net_core_PropertyInt
#ifdef __cplusplus
extern "C" {
#endif
/*
 * Class:     org_openhome_net_core_PropertyInt
 * Method:    ServicePropertyCreateIntCp
 * Signature: (Ljava/lang/String;Lorg/openhome/net/controlpoint/IPropertyChangeListener;)Lorg/openhome/net/core/Property/PropertyInitialised;
 */
JNIEXPORT jobject JNICALL Java_org_openhome_net_core_PropertyInt_ServicePropertyCreateIntCp
  (JNIEnv *, jobject, jstring, jobject);

/*
 * Class:     org_openhome_net_core_PropertyInt
 * Method:    ServicePropertyCreateIntDv
 * Signature: (J)J
 */
JNIEXPORT jlong JNICALL Java_org_openhome_net_core_PropertyInt_ServicePropertyCreateIntDv
  (JNIEnv *, jclass, jlong);

/*
 * Class:     org_openhome_net_core_PropertyInt
 * Method:    ServicePropertyValueInt
 * Signature: (J)I
 */
JNIEXPORT jint JNICALL Java_org_openhome_net_core_PropertyInt_ServicePropertyValueInt
  (JNIEnv *, jclass, jlong);

/*
 * Class:     org_openhome_net_core_PropertyInt
 * Method:    ServicePropertySetValueInt
 * Signature: (JI)I
 */
JNIEXPORT jint JNICALL Java_org_openhome_net_core_PropertyInt_ServicePropertySetValueInt
  (JNIEnv *, jclass, jlong, jint);

#ifdef __cplusplus
}
#endif
#endif
