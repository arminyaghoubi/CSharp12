<h1 align="center">CSharp 12</h1>

<p align="center">
  <i>Every New Feature Added in C# 12.</i>
</p>

## Description

Welcome to a collection of eight innovative projects developed to demonstrate the cutting-edge capabilities introduced in C# 12.
Each project serves as an embodiment of distinct functionalities and enhancements, meticulously crafted to highlight the versatility and power of the latest features within the C# ecosystem.

## Features

- **Primary Constructors:** You can now create primary constructors in any class and struct. Primary constructors are no longer restricted to record types.
- **Collection expressions:** Collection expressions introduce a new terse syntax to create common collection values. Inlining other collections into these values is possible using a spread operator ..
- **ref readonly parameters:** C# added in parameters as a way to pass readonly references. in parameters allow both variables and values, and can be used without any annotation on arguments.
- **Default lambda parameters:** You can now define default values for parameters on lambda expressions. The syntax and rules are the same as adding default values for arguments to any method or local function.
- **Alias any type:** You can use the using alias directive to alias any type, not just named types. That means you can create semantic aliases for tuple types, array types, pointer types, or other unsafe types.
- **Inline arrays:** Inline arrays are used by the runtime team and other library authors to improve performance in your apps. Inline arrays enable a developer to create an array of fixed size in a struct type.
- **Experimental attribute:** Types, methods, or assemblies can be marked with the System.Diagnostics.CodeAnalysis.ExperimentalAttribute to indicate an experimental feature. The compiler issues a warning if you access a method or type annotated with the ExperimentalAttribute. All types included in an assembly marked with the Experimental attribute are experimental.
- **Interceptors:** An interceptor is a method that can declaratively substitute a call to an interceptable method with a call to itself at compile time. This substitution occurs by having the interceptor declare the source locations of the calls that it intercepts. Interceptors provide a limited facility to change the semantics of existing code by adding new code to a compilation, for example in a source generator.

## Installation and Setup

Ensure you have the latest .NET SDK installed for your operating system.
