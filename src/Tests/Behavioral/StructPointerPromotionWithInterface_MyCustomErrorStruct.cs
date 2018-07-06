//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2018 July 06 21:24:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using static go.BuiltInFunctions;
using fmt = go.fmt_package;
using time = go.time_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.1.0")]
        [PromotedStruct(typeof(MyError))]
        public partial struct MyCustomError
        {
            // Abser.Abs function promotion
            private delegate double AbsByVal(T value);
            private delegate double AbsByRef(ref T value);

            private static readonly AbsByVal s_AbsByVal;
            private static readonly AbsByRef s_AbsByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public double Abs() => s_AbsByRef?.Invoke(ref this) ?? s_AbsByVal?.Invoke(this) ?? Abser?.Abs() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // MyError structure promotion - sourced from pointer
            private readonly Ref<MyError> m_MyErrorRef;

            private ref MyError MyError_ptr => ref m_MyErrorRef.Value;

            public ref time.Time When => ref m_MyErrorRef.Value.When;

            public ref GoString What => ref m_MyErrorRef.Value.What;
            
            [DebuggerStepperBoundary]
            static MyCustomError()
            {
                Type targetType = typeof(MyCustomError);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Abs");

                if ((object)extensionMethod != null)
                {
                    s_AbsByRef = extensionMethod.CreateStaticDelegate(typeof(AbsByRef)) as AbsByRef;

                    if ((object)s_AbsByRef == null)
                        s_AbsByVal = extensionMethod.CreateStaticDelegate(typeof(AbsByVal)) as AbsByVal;
                }
            }

            // Constructors
            public MyCustomError(NilType _)
            {
                this.Message = default;
                this.Abser = default;
                this.m_MyErrorRef = new Ref<MyError>(new MyError(nil));
            }

            public MyCustomError(GoString Message, Abser Abser, ref MyError MyError)
            {
                this.Message = Message;
                this.Abser = Abser;
                this.m_MyErrorRef = new Ref<MyError>(ref MyError);
            }

            // Enable comparisons between nil and MyCustomError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MyCustomError value, NilType nil) => value.Equals(default(MyCustomError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MyCustomError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MyCustomError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MyCustomError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyCustomError(NilType nil) => default(MyCustomError);
        }
    }
}