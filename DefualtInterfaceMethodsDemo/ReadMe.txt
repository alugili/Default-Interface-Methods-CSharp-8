Default Interface Methods C# 8 in depth

Examples and Code Demos for the Default Interface Methods

Default Interface Methods:

- A Very simple example 
- Keyword abstract and virtual
- Using the keyword This
- Using Properties
- Diamond Problem
- Using Async
- Generic 
- Player example
- Limitations and errors

For more information:

Required:
Visual Studio 2017 Build 15.6.2

How to build:

Download the source code from Github:

1) Clone the repository  https://github.com/dotnet/roslyn
2) Switch to the branch https://github.com/dotnet/roslyn/tree/features/DefaultInterfaceImplementation
3) Read and folow the roslyn How To build: execute Restore.cmd and then Build.cmd
4) Open the roslyn solution file and change the following files:
        
      ..src\Compilers\CSharp\Portable\CSharpParseOptions.cs

        To

        internal bool IsFeatureEnabled(MessageID feature)
        {
    
            return true;
        }



..src\Compilers\CSharp\Portable\Parser\SyntaxParser.cs

	To


        protected bool IsFeatureEnabled(MessageID feature)
        {

            return true;
        }

5) Select and set "VisualStudioSetup.Next" as StartUp Project
6) F5 and when the new Visual Studio is started then open the DefualtInterfaceMethodsDemo.sln
7) F5 and enjoy the new Feature :-) !



