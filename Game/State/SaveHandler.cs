﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Game.State
{
    public class SaveHandler
    {
        DateTime lastSave = DateTime.MinValue;
        string filename = Directory.GetCurrentDirectory() + "\\Resources\\save.xml";

        public void Save(GameState state)
        {
            Saver.Save(filename, state);
            lastSave = File.GetLastWriteTime(filename);
        }

        public GameState Load()
        {
            return Loader.Load(filename);
        }

        public SaveHandler()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Path.GetDirectoryName(filename);
            watcher.Filter = "*.xml";
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += OnChanged;
            watcher.Created += OnChanged;
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e) {
            if (File.GetLastWriteTime(filename) > lastSave)
            {
                lastSave = File.GetLastWriteTime(filename).AddSeconds(1);
                
                OnManualSaveChange();
            }
        }

        public Action OnManualSaveChange { get; set; }
    }
}