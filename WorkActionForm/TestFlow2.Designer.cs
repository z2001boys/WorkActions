namespace WorkActionForm
{
    partial class TestFlow2
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.startState1 = new Egg.StartState();
            this.processState1 = new Egg.ProcessState();
            this.SuspendLayout();
            // 
            // startState1
            // 
            this.startState1.BackColor = System.Drawing.Color.Red;
            this.startState1.Location = new System.Drawing.Point(46, 105);
            this.startState1.Name = "startState1";
            this.startState1.NextAction = null;
            this.startState1.Size = new System.Drawing.Size(150, 50);
            this.startState1.TabIndex = 0;
            // 
            // processState1
            // 
            this.processState1.BackColor = System.Drawing.Color.LightBlue;
            this.processState1.Location = new System.Drawing.Point(46, 260);
            this.processState1.Name = "processState1";
            this.processState1.NextAction = null;
            this.processState1.Size = new System.Drawing.Size(150, 56);
            this.processState1.TabIndex = 1;
            // 
            // TestFlow2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.processState1);
            this.Controls.Add(this.startState1);
            this.Name = "TestFlow2";
            this.Size = new System.Drawing.Size(666, 503);
            this.ResumeLayout(false);

        }

        #endregion

        private Egg.StartState startState1;
        private Egg.ProcessState processState1;
    }
}
