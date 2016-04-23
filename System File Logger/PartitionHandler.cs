using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SysFileLogger
{
    public class PartitionHandler
    {
        private DriveInfo[] partitions;
        private String partitionPath;

        public PartitionHandler()
        {
            GetActivePartitions();
        }

        public string PartitionPath
        {
            get
            {
                return partitionPath;
            }

            set
            {
                partitionPath = value;
            }
        }

        public DriveInfo[] Partitions()
        {
            return partitions;
        }

        public void GetActivePartitions()
        {
            partitions = DriveInfo.GetDrives();
            foreach (DriveInfo item in partitions)
            {
                if(item.IsReady)
                {
                    PartitionPath = item.Name;
                }
            }
        }
    }
}
