#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodExecutionContextInfo g_methodExecutionContextInfos[1] = 
{
	{ 17189, 0,  0 } /*tableIndex: 0 */,
};
#else
static const Il2CppMethodExecutionContextInfo g_methodExecutionContextInfos[1] = { { 0, 0, 0 } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const char* g_methodExecutionContextInfoStrings[1] = 
{
	"particle",
};
#else
static const char* g_methodExecutionContextInfoStrings[1] = { NULL };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodExecutionContextInfoIndex g_methodExecutionContextInfoIndexes[45] = 
{
	{ 0, 1 } /* 0x06000001 System.Void UnityEngine.ParticleSystem::Emit(UnityEngine.Vector3,UnityEngine.Vector3,System.Single,System.Single,UnityEngine.Color32) */,
	{ 0, 0 } /* 0x06000002 System.Void UnityEngine.ParticleSystem::Emit(UnityEngine.ParticleSystem/Particle) */,
	{ 0, 0 } /* 0x06000003 System.Single UnityEngine.ParticleSystem::get_time() */,
	{ 0, 0 } /* 0x06000004 System.Void UnityEngine.ParticleSystem::set_randomSeed(System.UInt32) */,
	{ 0, 0 } /* 0x06000005 System.Boolean UnityEngine.ParticleSystem::get_useAutoRandomSeed() */,
	{ 0, 0 } /* 0x06000006 System.Void UnityEngine.ParticleSystem::set_useAutoRandomSeed(System.Boolean) */,
	{ 0, 0 } /* 0x06000007 System.Void UnityEngine.ParticleSystem::SetParticles(UnityEngine.ParticleSystem/Particle[],System.Int32,System.Int32) */,
	{ 0, 0 } /* 0x06000008 System.Void UnityEngine.ParticleSystem::SetParticles(UnityEngine.ParticleSystem/Particle[],System.Int32) */,
	{ 0, 0 } /* 0x06000009 System.Void UnityEngine.ParticleSystem::Simulate(System.Single,System.Boolean,System.Boolean,System.Boolean) */,
	{ 0, 0 } /* 0x0600000A System.Void UnityEngine.ParticleSystem::Stop(System.Boolean,UnityEngine.ParticleSystemStopBehavior) */,
	{ 0, 0 } /* 0x0600000B System.Void UnityEngine.ParticleSystem::Emit(System.Int32) */,
	{ 0, 0 } /* 0x0600000C System.Void UnityEngine.ParticleSystem::Emit_Internal(System.Int32) */,
	{ 0, 0 } /* 0x0600000D System.Void UnityEngine.ParticleSystem::Emit(UnityEngine.ParticleSystem/EmitParams,System.Int32) */,
	{ 0, 0 } /* 0x0600000E System.Void UnityEngine.ParticleSystem::EmitOld_Internal(UnityEngine.ParticleSystem/Particle&) */,
	{ 0, 0 } /* 0x0600000F UnityEngine.ParticleSystem/MainModule UnityEngine.ParticleSystem::get_main() */,
	{ 0, 0 } /* 0x06000010 UnityEngine.ParticleSystem/SubEmittersModule UnityEngine.ParticleSystem::get_subEmitters() */,
	{ 0, 0 } /* 0x06000011 System.Void UnityEngine.ParticleSystem::.ctor() */,
	{ 0, 0 } /* 0x06000012 System.Void UnityEngine.ParticleSystem::Emit_Injected(UnityEngine.ParticleSystem/EmitParams&,System.Int32) */,
	{ 0, 0 } /* 0x06000013 System.Void UnityEngine.ParticleSystem/MainModule::.ctor(UnityEngine.ParticleSystem) */,
	{ 0, 0 } /* 0x06000014 System.Single UnityEngine.ParticleSystem/MainModule::get_duration() */,
	{ 0, 0 } /* 0x06000015 System.Boolean UnityEngine.ParticleSystem/MainModule::get_loop() */,
	{ 0, 0 } /* 0x06000016 UnityEngine.ParticleSystem/MinMaxCurve UnityEngine.ParticleSystem/MainModule::get_startSize() */,
	{ 0, 0 } /* 0x06000017 UnityEngine.ParticleSystem/MinMaxGradient UnityEngine.ParticleSystem/MainModule::get_startColor() */,
	{ 0, 0 } /* 0x06000018 System.Single UnityEngine.ParticleSystem/MainModule::get_duration_Injected(UnityEngine.ParticleSystem/MainModule&) */,
	{ 0, 0 } /* 0x06000019 System.Boolean UnityEngine.ParticleSystem/MainModule::get_loop_Injected(UnityEngine.ParticleSystem/MainModule&) */,
	{ 0, 0 } /* 0x0600001A System.Void UnityEngine.ParticleSystem/MainModule::get_startSize_Injected(UnityEngine.ParticleSystem/MainModule&,UnityEngine.ParticleSystem/MinMaxCurve&) */,
	{ 0, 0 } /* 0x0600001B System.Void UnityEngine.ParticleSystem/MainModule::get_startColor_Injected(UnityEngine.ParticleSystem/MainModule&,UnityEngine.ParticleSystem/MinMaxGradient&) */,
	{ 0, 0 } /* 0x0600001C System.Void UnityEngine.ParticleSystem/SubEmittersModule::.ctor(UnityEngine.ParticleSystem) */,
	{ 0, 0 } /* 0x0600001D System.Int32 UnityEngine.ParticleSystem/SubEmittersModule::get_subEmittersCount() */,
	{ 0, 0 } /* 0x0600001E UnityEngine.ParticleSystem UnityEngine.ParticleSystem/SubEmittersModule::GetSubEmitterSystem(System.Int32) */,
	{ 0, 0 } /* 0x0600001F System.Int32 UnityEngine.ParticleSystem/SubEmittersModule::get_subEmittersCount_Injected(UnityEngine.ParticleSystem/SubEmittersModule&) */,
	{ 0, 0 } /* 0x06000020 UnityEngine.ParticleSystem UnityEngine.ParticleSystem/SubEmittersModule::GetSubEmitterSystem_Injected(UnityEngine.ParticleSystem/SubEmittersModule&,System.Int32) */,
	{ 0, 0 } /* 0x06000021 System.Void UnityEngine.ParticleSystem/Particle::set_lifetime(System.Single) */,
	{ 0, 0 } /* 0x06000022 System.Void UnityEngine.ParticleSystem/Particle::set_position(UnityEngine.Vector3) */,
	{ 0, 0 } /* 0x06000023 System.Void UnityEngine.ParticleSystem/Particle::set_velocity(UnityEngine.Vector3) */,
	{ 0, 0 } /* 0x06000024 System.Void UnityEngine.ParticleSystem/Particle::set_remainingLifetime(System.Single) */,
	{ 0, 0 } /* 0x06000025 System.Void UnityEngine.ParticleSystem/Particle::set_startLifetime(System.Single) */,
	{ 0, 0 } /* 0x06000026 System.Void UnityEngine.ParticleSystem/Particle::set_startColor(UnityEngine.Color32) */,
	{ 0, 0 } /* 0x06000027 System.Void UnityEngine.ParticleSystem/Particle::set_randomSeed(System.UInt32) */,
	{ 0, 0 } /* 0x06000028 System.Void UnityEngine.ParticleSystem/Particle::set_startSize(System.Single) */,
	{ 0, 0 } /* 0x06000029 System.Void UnityEngine.ParticleSystem/Particle::set_rotation3D(UnityEngine.Vector3) */,
	{ 0, 0 } /* 0x0600002A System.Void UnityEngine.ParticleSystem/Particle::set_angularVelocity3D(UnityEngine.Vector3) */,
	{ 0, 0 } /* 0x0600002B System.Single UnityEngine.ParticleSystem/MinMaxCurve::get_constant() */,
	{ 0, 0 } /* 0x0600002C UnityEngine.Color UnityEngine.ParticleSystem/MinMaxGradient::get_color() */,
	{ 0, 0 } /* 0x0600002D System.Int32 UnityEngine.ParticleSystemRenderer::GetMeshes(UnityEngine.Mesh[]) */,
};
#else
static const Il2CppMethodExecutionContextInfoIndex g_methodExecutionContextInfoIndexes[1] = { { 0, 0} };
#endif
#if IL2CPP_MONO_DEBUGGER
IL2CPP_EXTERN_C Il2CppSequencePoint g_sequencePointsUnityEngine_ParticleSystemModule[];
Il2CppSequencePoint g_sequencePointsUnityEngine_ParticleSystemModule[133] = 
{
	{ 55199, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 0 } /* seqPointIndex: 0 */,
	{ 55199, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 1 } /* seqPointIndex: 1 */,
	{ 55199, 1, 120, 120, 9, 10, 0, kSequencePointKind_Normal, 0, 2 } /* seqPointIndex: 2 */,
	{ 55199, 1, 121, 121, 13, 78, 1, kSequencePointKind_Normal, 0, 3 } /* seqPointIndex: 3 */,
	{ 55199, 1, 122, 122, 13, 42, 9, kSequencePointKind_Normal, 0, 4 } /* seqPointIndex: 4 */,
	{ 55199, 1, 122, 122, 13, 42, 12, kSequencePointKind_StepOut, 0, 5 } /* seqPointIndex: 5 */,
	{ 55199, 1, 123, 123, 13, 42, 18, kSequencePointKind_Normal, 0, 6 } /* seqPointIndex: 6 */,
	{ 55199, 1, 123, 123, 13, 42, 21, kSequencePointKind_StepOut, 0, 7 } /* seqPointIndex: 7 */,
	{ 55199, 1, 124, 124, 13, 42, 27, kSequencePointKind_Normal, 0, 8 } /* seqPointIndex: 8 */,
	{ 55199, 1, 124, 124, 13, 42, 31, kSequencePointKind_StepOut, 0, 9 } /* seqPointIndex: 9 */,
	{ 55199, 1, 125, 125, 13, 47, 37, kSequencePointKind_Normal, 0, 10 } /* seqPointIndex: 10 */,
	{ 55199, 1, 125, 125, 13, 47, 41, kSequencePointKind_StepOut, 0, 11 } /* seqPointIndex: 11 */,
	{ 55199, 1, 126, 126, 13, 39, 47, kSequencePointKind_Normal, 0, 12 } /* seqPointIndex: 12 */,
	{ 55199, 1, 126, 126, 13, 39, 50, kSequencePointKind_StepOut, 0, 13 } /* seqPointIndex: 13 */,
	{ 55199, 1, 127, 127, 13, 48, 56, kSequencePointKind_Normal, 0, 14 } /* seqPointIndex: 14 */,
	{ 55199, 1, 127, 127, 13, 48, 58, kSequencePointKind_StepOut, 0, 15 } /* seqPointIndex: 15 */,
	{ 55199, 1, 127, 127, 13, 48, 63, kSequencePointKind_StepOut, 0, 16 } /* seqPointIndex: 16 */,
	{ 55199, 1, 128, 128, 13, 55, 69, kSequencePointKind_Normal, 0, 17 } /* seqPointIndex: 17 */,
	{ 55199, 1, 128, 128, 13, 55, 71, kSequencePointKind_StepOut, 0, 18 } /* seqPointIndex: 18 */,
	{ 55199, 1, 128, 128, 13, 55, 76, kSequencePointKind_StepOut, 0, 19 } /* seqPointIndex: 19 */,
	{ 55199, 1, 129, 129, 13, 41, 82, kSequencePointKind_Normal, 0, 20 } /* seqPointIndex: 20 */,
	{ 55199, 1, 129, 129, 13, 41, 86, kSequencePointKind_StepOut, 0, 21 } /* seqPointIndex: 21 */,
	{ 55199, 1, 130, 130, 13, 37, 92, kSequencePointKind_Normal, 0, 22 } /* seqPointIndex: 22 */,
	{ 55199, 1, 130, 130, 13, 37, 95, kSequencePointKind_StepOut, 0, 23 } /* seqPointIndex: 23 */,
	{ 55199, 1, 131, 131, 13, 44, 101, kSequencePointKind_Normal, 0, 24 } /* seqPointIndex: 24 */,
	{ 55199, 1, 131, 131, 13, 44, 104, kSequencePointKind_StepOut, 0, 25 } /* seqPointIndex: 25 */,
	{ 55199, 1, 132, 132, 9, 10, 110, kSequencePointKind_Normal, 0, 26 } /* seqPointIndex: 26 */,
	{ 55200, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 27 } /* seqPointIndex: 27 */,
	{ 55200, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 28 } /* seqPointIndex: 28 */,
	{ 55200, 1, 136, 136, 9, 10, 0, kSequencePointKind_Normal, 0, 29 } /* seqPointIndex: 29 */,
	{ 55200, 1, 137, 137, 13, 44, 1, kSequencePointKind_Normal, 0, 30 } /* seqPointIndex: 30 */,
	{ 55200, 1, 137, 137, 13, 44, 4, kSequencePointKind_StepOut, 0, 31 } /* seqPointIndex: 31 */,
	{ 55200, 1, 138, 138, 9, 10, 10, kSequencePointKind_Normal, 0, 32 } /* seqPointIndex: 32 */,
	{ 55206, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 33 } /* seqPointIndex: 33 */,
	{ 55206, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 34 } /* seqPointIndex: 34 */,
	{ 55206, 2, 95, 95, 72, 73, 0, kSequencePointKind_Normal, 0, 35 } /* seqPointIndex: 35 */,
	{ 55206, 2, 95, 95, 74, 107, 1, kSequencePointKind_Normal, 0, 36 } /* seqPointIndex: 36 */,
	{ 55206, 2, 95, 95, 74, 107, 5, kSequencePointKind_StepOut, 0, 37 } /* seqPointIndex: 37 */,
	{ 55206, 2, 95, 95, 108, 109, 11, kSequencePointKind_Normal, 0, 38 } /* seqPointIndex: 38 */,
	{ 55209, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 39 } /* seqPointIndex: 39 */,
	{ 55209, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 40 } /* seqPointIndex: 40 */,
	{ 55209, 2, 176, 176, 37, 38, 0, kSequencePointKind_Normal, 0, 41 } /* seqPointIndex: 41 */,
	{ 55209, 2, 176, 176, 39, 60, 1, kSequencePointKind_Normal, 0, 42 } /* seqPointIndex: 42 */,
	{ 55209, 2, 176, 176, 39, 60, 3, kSequencePointKind_StepOut, 0, 43 } /* seqPointIndex: 43 */,
	{ 55209, 2, 176, 176, 61, 62, 9, kSequencePointKind_Normal, 0, 44 } /* seqPointIndex: 44 */,
	{ 55213, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 45 } /* seqPointIndex: 45 */,
	{ 55213, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 46 } /* seqPointIndex: 46 */,
	{ 55213, 3, 635, 635, 38, 39, 0, kSequencePointKind_Normal, 0, 47 } /* seqPointIndex: 47 */,
	{ 55213, 3, 635, 635, 40, 68, 1, kSequencePointKind_Normal, 0, 48 } /* seqPointIndex: 48 */,
	{ 55213, 3, 635, 635, 40, 68, 2, kSequencePointKind_StepOut, 0, 49 } /* seqPointIndex: 49 */,
	{ 55213, 3, 635, 635, 69, 70, 10, kSequencePointKind_Normal, 0, 50 } /* seqPointIndex: 50 */,
	{ 55214, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 51 } /* seqPointIndex: 51 */,
	{ 55214, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 52 } /* seqPointIndex: 52 */,
	{ 55214, 3, 653, 653, 52, 53, 0, kSequencePointKind_Normal, 0, 53 } /* seqPointIndex: 53 */,
	{ 55214, 3, 653, 653, 54, 89, 1, kSequencePointKind_Normal, 0, 54 } /* seqPointIndex: 54 */,
	{ 55214, 3, 653, 653, 54, 89, 2, kSequencePointKind_StepOut, 0, 55 } /* seqPointIndex: 55 */,
	{ 55214, 3, 653, 653, 90, 91, 10, kSequencePointKind_Normal, 0, 56 } /* seqPointIndex: 56 */,
	{ 55217, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 57 } /* seqPointIndex: 57 */,
	{ 55217, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 58 } /* seqPointIndex: 58 */,
	{ 55217, 3, 20, 20, 64, 65, 0, kSequencePointKind_Normal, 0, 59 } /* seqPointIndex: 59 */,
	{ 55217, 3, 20, 20, 66, 100, 1, kSequencePointKind_Normal, 0, 60 } /* seqPointIndex: 60 */,
	{ 55217, 3, 20, 20, 101, 102, 8, kSequencePointKind_Normal, 0, 61 } /* seqPointIndex: 61 */,
	{ 55226, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 62 } /* seqPointIndex: 62 */,
	{ 55226, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 63 } /* seqPointIndex: 63 */,
	{ 55226, 3, 497, 497, 71, 72, 0, kSequencePointKind_Normal, 0, 64 } /* seqPointIndex: 64 */,
	{ 55226, 3, 497, 497, 73, 107, 1, kSequencePointKind_Normal, 0, 65 } /* seqPointIndex: 65 */,
	{ 55226, 3, 497, 497, 108, 109, 8, kSequencePointKind_Normal, 0, 66 } /* seqPointIndex: 66 */,
	{ 55231, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 67 } /* seqPointIndex: 67 */,
	{ 55231, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 68 } /* seqPointIndex: 68 */,
	{ 55231, 1, 94, 94, 75, 76, 0, kSequencePointKind_Normal, 0, 69 } /* seqPointIndex: 69 */,
	{ 55231, 1, 94, 94, 77, 103, 1, kSequencePointKind_Normal, 0, 70 } /* seqPointIndex: 70 */,
	{ 55231, 1, 94, 94, 77, 103, 3, kSequencePointKind_StepOut, 0, 71 } /* seqPointIndex: 71 */,
	{ 55231, 1, 94, 94, 104, 105, 9, kSequencePointKind_Normal, 0, 72 } /* seqPointIndex: 72 */,
	{ 55232, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 73 } /* seqPointIndex: 73 */,
	{ 55232, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 74 } /* seqPointIndex: 74 */,
	{ 55232, 4, 190, 190, 70, 71, 0, kSequencePointKind_Normal, 0, 75 } /* seqPointIndex: 75 */,
	{ 55232, 4, 190, 190, 72, 91, 1, kSequencePointKind_Normal, 0, 76 } /* seqPointIndex: 76 */,
	{ 55232, 4, 190, 190, 92, 93, 8, kSequencePointKind_Normal, 0, 77 } /* seqPointIndex: 77 */,
	{ 55233, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 78 } /* seqPointIndex: 78 */,
	{ 55233, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 79 } /* seqPointIndex: 79 */,
	{ 55233, 4, 191, 191, 70, 71, 0, kSequencePointKind_Normal, 0, 80 } /* seqPointIndex: 80 */,
	{ 55233, 4, 191, 191, 72, 91, 1, kSequencePointKind_Normal, 0, 81 } /* seqPointIndex: 81 */,
	{ 55233, 4, 191, 191, 92, 93, 8, kSequencePointKind_Normal, 0, 82 } /* seqPointIndex: 82 */,
	{ 55234, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 83 } /* seqPointIndex: 83 */,
	{ 55234, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 84 } /* seqPointIndex: 84 */,
	{ 55234, 4, 194, 194, 77, 78, 0, kSequencePointKind_Normal, 0, 85 } /* seqPointIndex: 85 */,
	{ 55234, 4, 194, 194, 79, 98, 1, kSequencePointKind_Normal, 0, 86 } /* seqPointIndex: 86 */,
	{ 55234, 4, 194, 194, 99, 100, 8, kSequencePointKind_Normal, 0, 87 } /* seqPointIndex: 87 */,
	{ 55235, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 88 } /* seqPointIndex: 88 */,
	{ 55235, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 89 } /* seqPointIndex: 89 */,
	{ 55235, 4, 195, 195, 78, 79, 0, kSequencePointKind_Normal, 0, 90 } /* seqPointIndex: 90 */,
	{ 55235, 4, 195, 195, 80, 104, 1, kSequencePointKind_Normal, 0, 91 } /* seqPointIndex: 91 */,
	{ 55235, 4, 195, 195, 105, 106, 8, kSequencePointKind_Normal, 0, 92 } /* seqPointIndex: 92 */,
	{ 55236, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 93 } /* seqPointIndex: 93 */,
	{ 55236, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 94 } /* seqPointIndex: 94 */,
	{ 55236, 4, 196, 196, 74, 75, 0, kSequencePointKind_Normal, 0, 95 } /* seqPointIndex: 95 */,
	{ 55236, 4, 196, 196, 76, 97, 1, kSequencePointKind_Normal, 0, 96 } /* seqPointIndex: 96 */,
	{ 55236, 4, 196, 196, 98, 99, 8, kSequencePointKind_Normal, 0, 97 } /* seqPointIndex: 97 */,
	{ 55237, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 98 } /* seqPointIndex: 98 */,
	{ 55237, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 99 } /* seqPointIndex: 99 */,
	{ 55237, 4, 197, 197, 73, 74, 0, kSequencePointKind_Normal, 0, 100 } /* seqPointIndex: 100 */,
	{ 55237, 4, 197, 197, 75, 96, 1, kSequencePointKind_Normal, 0, 101 } /* seqPointIndex: 101 */,
	{ 55237, 4, 197, 197, 97, 98, 8, kSequencePointKind_Normal, 0, 102 } /* seqPointIndex: 102 */,
	{ 55238, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 103 } /* seqPointIndex: 103 */,
	{ 55238, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 104 } /* seqPointIndex: 104 */,
	{ 55238, 4, 200, 200, 72, 73, 0, kSequencePointKind_Normal, 0, 105 } /* seqPointIndex: 105 */,
	{ 55238, 4, 200, 200, 74, 121, 1, kSequencePointKind_Normal, 0, 106 } /* seqPointIndex: 106 */,
	{ 55238, 4, 200, 200, 74, 121, 5, kSequencePointKind_StepOut, 0, 107 } /* seqPointIndex: 107 */,
	{ 55238, 4, 200, 200, 122, 123, 15, kSequencePointKind_Normal, 0, 108 } /* seqPointIndex: 108 */,
	{ 55239, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 109 } /* seqPointIndex: 109 */,
	{ 55239, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 110 } /* seqPointIndex: 110 */,
	{ 55239, 4, 204, 204, 88, 89, 0, kSequencePointKind_Normal, 0, 111 } /* seqPointIndex: 111 */,
	{ 55239, 4, 204, 204, 90, 125, 1, kSequencePointKind_Normal, 0, 112 } /* seqPointIndex: 112 */,
	{ 55239, 4, 204, 204, 90, 125, 8, kSequencePointKind_StepOut, 0, 113 } /* seqPointIndex: 113 */,
	{ 55239, 4, 204, 204, 126, 162, 18, kSequencePointKind_Normal, 0, 114 } /* seqPointIndex: 114 */,
	{ 55239, 4, 204, 204, 163, 164, 32, kSequencePointKind_Normal, 0, 115 } /* seqPointIndex: 115 */,
	{ 55240, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 116 } /* seqPointIndex: 116 */,
	{ 55240, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 117 } /* seqPointIndex: 117 */,
	{ 55240, 4, 207, 207, 102, 103, 0, kSequencePointKind_Normal, 0, 118 } /* seqPointIndex: 118 */,
	{ 55240, 4, 207, 207, 104, 146, 1, kSequencePointKind_Normal, 0, 119 } /* seqPointIndex: 119 */,
	{ 55240, 4, 207, 207, 104, 146, 8, kSequencePointKind_StepOut, 0, 120 } /* seqPointIndex: 120 */,
	{ 55240, 4, 207, 207, 147, 183, 18, kSequencePointKind_Normal, 0, 121 } /* seqPointIndex: 121 */,
	{ 55240, 4, 207, 207, 184, 185, 32, kSequencePointKind_Normal, 0, 122 } /* seqPointIndex: 122 */,
	{ 55241, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 123 } /* seqPointIndex: 123 */,
	{ 55241, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 124 } /* seqPointIndex: 124 */,
	{ 55241, 4, 91, 91, 41, 42, 0, kSequencePointKind_Normal, 0, 125 } /* seqPointIndex: 125 */,
	{ 55241, 4, 91, 91, 43, 64, 1, kSequencePointKind_Normal, 0, 126 } /* seqPointIndex: 126 */,
	{ 55241, 4, 91, 91, 65, 66, 10, kSequencePointKind_Normal, 0, 127 } /* seqPointIndex: 127 */,
	{ 55242, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 128 } /* seqPointIndex: 128 */,
	{ 55242, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 129 } /* seqPointIndex: 129 */,
	{ 55242, 4, 138, 138, 38, 39, 0, kSequencePointKind_Normal, 0, 130 } /* seqPointIndex: 130 */,
	{ 55242, 4, 138, 138, 40, 58, 1, kSequencePointKind_Normal, 0, 131 } /* seqPointIndex: 131 */,
	{ 55242, 4, 138, 138, 59, 60, 10, kSequencePointKind_Normal, 0, 132 } /* seqPointIndex: 132 */,
};
#else
extern Il2CppSequencePoint g_sequencePointsUnityEngine_ParticleSystemModule[];
Il2CppSequencePoint g_sequencePointsUnityEngine_ParticleSystemModule[1] = { { 0, 0, 0, 0, 0, 0, 0, kSequencePointKind_Normal, 0, 0, } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppCatchPoint g_catchPoints[1] = { { 0, 0, 0, 0, } };
#else
static const Il2CppCatchPoint g_catchPoints[1] = { { 0, 0, 0, 0, } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppSequencePointSourceFile g_sequencePointSourceFiles[] = {
{ "", { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} }, //0 
{ "C:\\build\\output\\unity\\unity\\Modules\\ParticleSystem\\Managed\\ParticleSystem.deprecated.cs", { 254, 108, 111, 128, 100, 7, 222, 4, 156, 244, 245, 164, 175, 217, 189, 197} }, //1 
{ "C:\\build\\output\\unity\\unity\\Modules\\ParticleSystem\\ScriptBindings\\ParticleSystem.bindings.cs", { 236, 65, 203, 223, 251, 100, 230, 5, 113, 251, 2, 165, 182, 52, 78, 2} }, //2 
{ "C:\\build\\output\\unity\\unity\\Modules\\ParticleSystem\\ScriptBindings\\ParticleSystemModules.bindings.cs", { 3, 133, 160, 165, 97, 183, 14, 149, 224, 6, 3, 184, 42, 99, 31, 70} }, //3 
{ "C:\\build\\output\\unity\\unity\\Modules\\ParticleSystem\\Managed\\ParticleSystemStructs.cs", { 220, 239, 182, 144, 220, 43, 200, 140, 248, 250, 235, 227, 210, 7, 223, 37} }, //4 
};
#else
static const Il2CppSequencePointSourceFile g_sequencePointSourceFiles[1] = { NULL, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppTypeSourceFilePair g_typeSourceFiles[9] = 
{
	{ 6324, 1 },
	{ 6324, 2 },
	{ 6324, 3 },
	{ 6318, 3 },
	{ 6319, 3 },
	{ 6320, 1 },
	{ 6320, 4 },
	{ 6321, 4 },
	{ 6322, 4 },
};
#else
static const Il2CppTypeSourceFilePair g_typeSourceFiles[1] = { { 0, 0 } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodScope g_methodScopes[5] = 
{
	{ 0, 111 },
	{ 0, 12 },
	{ 0, 12 },
	{ 0, 12 },
	{ 0, 12 },
};
#else
static const Il2CppMethodScope g_methodScopes[1] = { { 0, 0 } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodHeaderInfo g_methodHeaderInfos[45] = 
{
	{ 111, 0, 1 } /* System.Void UnityEngine.ParticleSystem::Emit(UnityEngine.Vector3,UnityEngine.Vector3,System.Single,System.Single,UnityEngine.Color32) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem::Emit(UnityEngine.ParticleSystem/Particle) */,
	{ 0, 0, 0 } /* System.Single UnityEngine.ParticleSystem::get_time() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem::set_randomSeed(System.UInt32) */,
	{ 0, 0, 0 } /* System.Boolean UnityEngine.ParticleSystem::get_useAutoRandomSeed() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem::set_useAutoRandomSeed(System.Boolean) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem::SetParticles(UnityEngine.ParticleSystem/Particle[],System.Int32,System.Int32) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem::SetParticles(UnityEngine.ParticleSystem/Particle[],System.Int32) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem::Simulate(System.Single,System.Boolean,System.Boolean,System.Boolean) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem::Stop(System.Boolean,UnityEngine.ParticleSystemStopBehavior) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem::Emit(System.Int32) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem::Emit_Internal(System.Int32) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem::Emit(UnityEngine.ParticleSystem/EmitParams,System.Int32) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem::EmitOld_Internal(UnityEngine.ParticleSystem/Particle&) */,
	{ 12, 1, 1 } /* UnityEngine.ParticleSystem/MainModule UnityEngine.ParticleSystem::get_main() */,
	{ 12, 2, 1 } /* UnityEngine.ParticleSystem/SubEmittersModule UnityEngine.ParticleSystem::get_subEmitters() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem::.ctor() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem::Emit_Injected(UnityEngine.ParticleSystem/EmitParams&,System.Int32) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem/MainModule::.ctor(UnityEngine.ParticleSystem) */,
	{ 0, 0, 0 } /* System.Single UnityEngine.ParticleSystem/MainModule::get_duration() */,
	{ 0, 0, 0 } /* System.Boolean UnityEngine.ParticleSystem/MainModule::get_loop() */,
	{ 0, 0, 0 } /* UnityEngine.ParticleSystem/MinMaxCurve UnityEngine.ParticleSystem/MainModule::get_startSize() */,
	{ 0, 0, 0 } /* UnityEngine.ParticleSystem/MinMaxGradient UnityEngine.ParticleSystem/MainModule::get_startColor() */,
	{ 0, 0, 0 } /* System.Single UnityEngine.ParticleSystem/MainModule::get_duration_Injected(UnityEngine.ParticleSystem/MainModule&) */,
	{ 0, 0, 0 } /* System.Boolean UnityEngine.ParticleSystem/MainModule::get_loop_Injected(UnityEngine.ParticleSystem/MainModule&) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem/MainModule::get_startSize_Injected(UnityEngine.ParticleSystem/MainModule&,UnityEngine.ParticleSystem/MinMaxCurve&) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem/MainModule::get_startColor_Injected(UnityEngine.ParticleSystem/MainModule&,UnityEngine.ParticleSystem/MinMaxGradient&) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem/SubEmittersModule::.ctor(UnityEngine.ParticleSystem) */,
	{ 0, 0, 0 } /* System.Int32 UnityEngine.ParticleSystem/SubEmittersModule::get_subEmittersCount() */,
	{ 0, 0, 0 } /* UnityEngine.ParticleSystem UnityEngine.ParticleSystem/SubEmittersModule::GetSubEmitterSystem(System.Int32) */,
	{ 0, 0, 0 } /* System.Int32 UnityEngine.ParticleSystem/SubEmittersModule::get_subEmittersCount_Injected(UnityEngine.ParticleSystem/SubEmittersModule&) */,
	{ 0, 0, 0 } /* UnityEngine.ParticleSystem UnityEngine.ParticleSystem/SubEmittersModule::GetSubEmitterSystem_Injected(UnityEngine.ParticleSystem/SubEmittersModule&,System.Int32) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem/Particle::set_lifetime(System.Single) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem/Particle::set_position(UnityEngine.Vector3) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem/Particle::set_velocity(UnityEngine.Vector3) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem/Particle::set_remainingLifetime(System.Single) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem/Particle::set_startLifetime(System.Single) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem/Particle::set_startColor(UnityEngine.Color32) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem/Particle::set_randomSeed(System.UInt32) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem/Particle::set_startSize(System.Single) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem/Particle::set_rotation3D(UnityEngine.Vector3) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.ParticleSystem/Particle::set_angularVelocity3D(UnityEngine.Vector3) */,
	{ 12, 3, 1 } /* System.Single UnityEngine.ParticleSystem/MinMaxCurve::get_constant() */,
	{ 12, 4, 1 } /* UnityEngine.Color UnityEngine.ParticleSystem/MinMaxGradient::get_color() */,
	{ 0, 0, 0 } /* System.Int32 UnityEngine.ParticleSystemRenderer::GetMeshes(UnityEngine.Mesh[]) */,
};
#else
static const Il2CppMethodHeaderInfo g_methodHeaderInfos[1] = { { 0, 0, 0 } };
#endif
IL2CPP_EXTERN_C const Il2CppDebuggerMetadataRegistration g_DebuggerMetadataRegistrationUnityEngine_ParticleSystemModule;
const Il2CppDebuggerMetadataRegistration g_DebuggerMetadataRegistrationUnityEngine_ParticleSystemModule = 
{
	(Il2CppMethodExecutionContextInfo*)g_methodExecutionContextInfos,
	(Il2CppMethodExecutionContextInfoIndex*)g_methodExecutionContextInfoIndexes,
	(Il2CppMethodScope*)g_methodScopes,
	(Il2CppMethodHeaderInfo*)g_methodHeaderInfos,
	(Il2CppSequencePointSourceFile*)g_sequencePointSourceFiles,
	133,
	(Il2CppSequencePoint*)g_sequencePointsUnityEngine_ParticleSystemModule,
	0,
	(Il2CppCatchPoint*)g_catchPoints,
	9,
	(Il2CppTypeSourceFilePair*)g_typeSourceFiles,
	(const char**)g_methodExecutionContextInfoStrings,
};
