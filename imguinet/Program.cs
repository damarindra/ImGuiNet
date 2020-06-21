using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using System;

namespace imguinet
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleDriver.Run(new ImGuiLib());
		}
	}

	public class ImGuiLib : ILibrary
	{

		public void Setup(Driver driver)
		{
			var options = driver.Options;
			options.GeneratorKind = GeneratorKind.CSharp;
			var module = options.AddModule("imgui");
			module.IncludeDirs.Add(@"E:\E_Documents\MonoGameLib\ImGuiNet\imgui");
			//module.Headers.Add("imconfig.h");
			//module.Headers.Add("imgui_internal.h");
			module.Headers.Add("imgui.h");
			module.LibraryDirs.Add(@"E:\E_Documents\MonoGameLib\ImGuiNet\Release");
			module.Libraries.Add("imguivs.lib");
		}

		public void SetupPasses(Driver driver)
		{
		}

		public void Postprocess(Driver driver, ASTContext ctx)
		{
		}

		public void Preprocess(Driver driver, ASTContext ctx)
		{
		}
	}
}
