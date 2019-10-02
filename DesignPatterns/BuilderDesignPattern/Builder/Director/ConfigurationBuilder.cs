using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using Web.Builder.IBuilder;

namespace Web.Builder.Director
{
    public class ConfigurationBuilder
    {
        public void BuildSystem(ISystemBuilder systemBuilder, NameValueCollection collection)
        {
            //systemBuilder.AddDrive(collection["HDDSize"]);
            //systemBuilder.AddMemory(collection["RAM"]);
            //systemBuilder.AddMouse(collection["Mouse"]);
            //systemBuilder.AddKeyboard(collection["Keyboard"]);
            //systemBuilder.AddTouchScreen(collection["TouchScreen"]);

            systemBuilder.AddDrive(collection["HDDSize"]).
            AddMemory(collection["RAM"]).
            AddMouse(collection["Mouse"]).
            AddKeyboard(collection["Keyboard"]).
            AddTouchScreen(collection["TouchScreen"]);
        }
    }
}