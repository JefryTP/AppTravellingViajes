; ModuleID = 'obj\Release\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Release\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [102 x i32] [
	i32 34715100, ; 0: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 46
	i32 39109920, ; 1: Newtonsoft.Json.dll => 0x254c520 => 7
	i32 57263871, ; 2: Xamarin.Forms.Core.dll => 0x369c6ff => 41
	i32 137372943, ; 3: TravellingViajes.Android.dll => 0x830250f => 0
	i32 182336117, ; 4: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 38
	i32 230752869, ; 5: Microsoft.CSharp.dll => 0xdc10265 => 49
	i32 318968648, ; 6: Xamarin.AndroidX.Activity.dll => 0x13031348 => 22
	i32 321597661, ; 7: System.Numerics => 0x132b30dd => 17
	i32 342366114, ; 8: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 32
	i32 347068432, ; 9: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 12
	i32 398973096, ; 10: TravellingViajes.Android => 0x17c7d8a8 => 0
	i32 442521989, ; 11: Xamarin.Essentials => 0x1a605985 => 40
	i32 450948140, ; 12: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 30
	i32 465846621, ; 13: mscorlib => 0x1bc4415d => 6
	i32 469710990, ; 14: System.dll => 0x1bff388e => 16
	i32 627609679, ; 15: Xamarin.AndroidX.CustomView => 0x2568904f => 28
	i32 690569205, ; 16: System.Xml.Linq.dll => 0x29293ff5 => 20
	i32 748832960, ; 17: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 10
	i32 809851609, ; 18: System.Drawing.Common.dll => 0x30455ad9 => 48
	i32 928116545, ; 19: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 46
	i32 955402788, ; 20: Newtonsoft.Json => 0x38f24a24 => 7
	i32 967690846, ; 21: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 32
	i32 974778368, ; 22: FormsViewGroup.dll => 0x3a19f000 => 3
	i32 1012816738, ; 23: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 37
	i32 1035644815, ; 24: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 24
	i32 1042160112, ; 25: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 43
	i32 1052210849, ; 26: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 34
	i32 1098259244, ; 27: System => 0x41761b2c => 16
	i32 1292207520, ; 28: SQLitePCLRaw.core.dll => 0x4d0585a0 => 11
	i32 1293217323, ; 29: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 29
	i32 1365406463, ; 30: System.ServiceModel.Internals.dll => 0x516272ff => 47
	i32 1376866003, ; 31: Xamarin.AndroidX.SavedState => 0x52114ed3 => 37
	i32 1406073936, ; 32: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 26
	i32 1411638395, ; 33: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 18
	i32 1429273685, ; 34: TravellingViajes => 0x5530fc55 => 21
	i32 1460219004, ; 35: Xamarin.Forms.Xaml => 0x57092c7c => 44
	i32 1469204771, ; 36: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 23
	i32 1592978981, ; 37: System.Runtime.Serialization.dll => 0x5ef2ee25 => 2
	i32 1604451928, ; 38: SQLiteNetExtensions => 0x5fa1fe58 => 9
	i32 1622152042, ; 39: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 35
	i32 1639515021, ; 40: System.Net.Http.dll => 0x61b9038d => 1
	i32 1658251792, ; 41: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 45
	i32 1666713512, ; 42: SQLiteNetExtensions.dll => 0x635807a8 => 9
	i32 1711441057, ; 43: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 12
	i32 1729485958, ; 44: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 25
	i32 1766324549, ; 45: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 38
	i32 1776026572, ; 46: System.Core.dll => 0x69dc03cc => 15
	i32 1788241197, ; 47: Xamarin.AndroidX.Fragment => 0x6a96652d => 30
	i32 1796686597, ; 48: TravellingViajes.dll => 0x6b174305 => 21
	i32 1808609942, ; 49: Xamarin.AndroidX.Loader => 0x6bcd3296 => 35
	i32 1813201214, ; 50: Xamarin.Google.Android.Material => 0x6c13413e => 45
	i32 1867746548, ; 51: Xamarin.Essentials.dll => 0x6f538cf4 => 40
	i32 1878053835, ; 52: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 44
	i32 2011961780, ; 53: System.Buffers.dll => 0x77ec19b4 => 14
	i32 2019465201, ; 54: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 34
	i32 2055257422, ; 55: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 33
	i32 2097448633, ; 56: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 31
	i32 2103459038, ; 57: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 13
	i32 2126786730, ; 58: Xamarin.Forms.Platform.Android => 0x7ec430aa => 42
	i32 2201231467, ; 59: System.Net.Http => 0x8334206b => 1
	i32 2279755925, ; 60: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 36
	i32 2465273461, ; 61: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 10
	i32 2475788418, ; 62: Java.Interop.dll => 0x93918882 => 4
	i32 2562349572, ; 63: Microsoft.CSharp => 0x98ba5a04 => 49
	i32 2732626843, ; 64: Xamarin.AndroidX.Activity => 0xa2e0939b => 22
	i32 2737747696, ; 65: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 23
	i32 2766581644, ; 66: Xamarin.Forms.Core => 0xa4e6af8c => 41
	i32 2778768386, ; 67: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 39
	i32 2810250172, ; 68: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 26
	i32 2819470561, ; 69: System.Xml.dll => 0xa80db4e1 => 19
	i32 2853208004, ; 70: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 39
	i32 2905242038, ; 71: mscorlib.dll => 0xad2a79b6 => 6
	i32 2978675010, ; 72: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 29
	i32 3044182254, ; 73: FormsViewGroup => 0xb57288ee => 3
	i32 3111772706, ; 74: System.Runtime.Serialization => 0xb979e222 => 2
	i32 3247949154, ; 75: Mono.Security => 0xc197c562 => 50
	i32 3258312781, ; 76: Xamarin.AndroidX.CardView => 0xc235e84d => 25
	i32 3286872994, ; 77: SQLite-net.dll => 0xc3e9b3a2 => 8
	i32 3317135071, ; 78: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 28
	i32 3353484488, ; 79: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 31
	i32 3360279109, ; 80: SQLitePCLRaw.core => 0xc849ca45 => 11
	i32 3362522851, ; 81: Xamarin.AndroidX.Core => 0xc86c06e3 => 27
	i32 3366347497, ; 82: Java.Interop => 0xc8a662e9 => 4
	i32 3374999561, ; 83: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 36
	i32 3395150330, ; 84: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 18
	i32 3404865022, ; 85: System.ServiceModel.Internals => 0xcaf21dfe => 47
	i32 3429136800, ; 86: System.Xml => 0xcc6479a0 => 19
	i32 3476120550, ; 87: Mono.Android => 0xcf3163e6 => 5
	i32 3509114376, ; 88: System.Xml.Linq => 0xd128d608 => 20
	i32 3536029504, ; 89: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 42
	i32 3632359727, ; 90: Xamarin.Forms.Platform => 0xd881692f => 43
	i32 3641597786, ; 91: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 33
	i32 3672681054, ; 92: Mono.Android.dll => 0xdae8aa5e => 5
	i32 3689375977, ; 93: System.Drawing.Common => 0xdbe768e9 => 48
	i32 3754567612, ; 94: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 13
	i32 3829621856, ; 95: System.Numerics.dll => 0xe4436460 => 17
	i32 3876362041, ; 96: SQLite-net => 0xe70c9739 => 8
	i32 3896760992, ; 97: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 27
	i32 3955647286, ; 98: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 24
	i32 4105002889, ; 99: Mono.Security.dll => 0xf4ad5f89 => 50
	i32 4151237749, ; 100: System.Core => 0xf76edc75 => 15
	i32 4260525087 ; 101: System.Buffers => 0xfdf2741f => 14
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [102 x i32] [
	i32 46, i32 7, i32 41, i32 0, i32 38, i32 49, i32 22, i32 17, ; 0..7
	i32 32, i32 12, i32 0, i32 40, i32 30, i32 6, i32 16, i32 28, ; 8..15
	i32 20, i32 10, i32 48, i32 46, i32 7, i32 32, i32 3, i32 37, ; 16..23
	i32 24, i32 43, i32 34, i32 16, i32 11, i32 29, i32 47, i32 37, ; 24..31
	i32 26, i32 18, i32 21, i32 44, i32 23, i32 2, i32 9, i32 35, ; 32..39
	i32 1, i32 45, i32 9, i32 12, i32 25, i32 38, i32 15, i32 30, ; 40..47
	i32 21, i32 35, i32 45, i32 40, i32 44, i32 14, i32 34, i32 33, ; 48..55
	i32 31, i32 13, i32 42, i32 1, i32 36, i32 10, i32 4, i32 49, ; 56..63
	i32 22, i32 23, i32 41, i32 39, i32 26, i32 19, i32 39, i32 6, ; 64..71
	i32 29, i32 3, i32 2, i32 50, i32 25, i32 8, i32 28, i32 31, ; 72..79
	i32 11, i32 27, i32 4, i32 36, i32 18, i32 47, i32 19, i32 5, ; 80..87
	i32 20, i32 42, i32 43, i32 33, i32 5, i32 48, i32 13, i32 17, ; 88..95
	i32 8, i32 27, i32 24, i32 50, i32 15, i32 14 ; 96..101
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}
