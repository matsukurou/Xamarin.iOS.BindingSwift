using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace TestLib
{
	partial interface Constants
	{
		// extern double MyFrameworkObjCVersionNumber;
		[Field ("MyFrameworkObjCVersionNumber", "__Internal")]
		double MyFrameworkObjCVersionNumber { get; }

		// extern const unsigned char [] MyFrameworkObjCVersionString;
		[Field ("MyFrameworkObjCVersionString", "__Internal")]
		byte[] MyFrameworkObjCVersionString { get; }
	}

	// @interface MyFrameworkObjC : NSObject
	[BaseType (typeof(NSObject))]
	interface MyFrameworkObjC
	{
		// +(id)initMyClass;
		//[Static]
		[Export ("initMyClass")]
		NSObject InitMyClass { get; }

		// -(NSString *)myMethod:(NSString *)myParameter;
		[Export ("myMethod:")]
		string MyMethod (string myParameter);

		// -(NSString *)createLib;
		[Export ("createLib")]
		string CreateLib { get; }
	}
}

