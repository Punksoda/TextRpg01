﻿using SpartaDungeon.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon.Scenes
{
    public class EntryScene : BaseScene
    {
        #region 새로운 생성자 만들기 금지
        // 생성자에서는 현재 씬의 이름만 설정한다. 씬에 있는 멤버들의 초기화는 Awake나 Start에서 한다
        public EntryScene(string name) : base(name) { }
        #endregion
        //
        public override void Awake()
        {

        }
        public override void Start()
        {

        }
        public override void Update()
        {

        }
    }
}
