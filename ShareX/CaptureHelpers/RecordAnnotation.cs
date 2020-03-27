#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (c) 2007-2020 ShareX Team

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using ShareX.HelpersLib;
using ShareX.ScreenCaptureLib;
using System.Drawing;
using System.Windows.Forms;

    namespace ShareX
{
    public class RecordAnnotation : CaptureBase
    {
        protected static RegionCaptureType lastRegionCaptureType = RegionCaptureType.Default;

        public RegionCaptureType RegionCaptureType { get; protected set; }

        public RecordAnnotation()
        {
        }
  
        protected override ImageInfo Execute(TaskSettings taskSettings)
        {
                    return ExecuteRegionCapture(taskSettings);
        }

        protected ImageInfo ExecuteRegionCapture(TaskSettings taskSettings)
        {
            ImageInfo imageInfo = new ImageInfo();
            CursorData cursorData = null;
          
            if (taskSettings.CaptureSettings.ShowCursor)
            {
                cursorData = new CursorData();
            }

            using (RegionCaptureForm form = new RegionCaptureForm(RegionCaptureMode.Annotation, taskSettings.CaptureSettingsReference.SurfaceOptions/*, img*/))
            {
                if (cursorData != null && cursorData.IsVisible)
                {
                    form.AddCursor(cursorData.Handle, CaptureHelpers.ScreenToClient(cursorData.Position));
                }
               form.Closable = false;

               ScreenRecordManager.recordForm.StopRequested += () =>
                  {

                      form.Closable = true;
                      form.Close();
                  };
                form.ShowDialog();

            }
            return imageInfo;
        }
        
    }
   

}