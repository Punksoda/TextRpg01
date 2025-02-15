﻿using SpartaDungeon.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon.Scenes
{
    public class InventoryScene : BaseScene
    {
        // 초기 멤버
        Player player;
        #region 새로운 생성자 만들기 금지
        // 생성자에서는 현재 씬의 이름만 설정한다. 씬에 있는 멤버들의 초기화는 Awake나 Start에서 한다
        public InventoryScene(string name) : base(name) { }
        #endregion
        //
        public override void Awake()
        {
        }
        public override void Start()
        {
            // 플레이어의 아이템을 보여주는데, 플레이어의 아이템은 DataManager가 가지고 있어서 안전하다
            player = DataManager.Instance.player;
        }
        public override void Update()
        {
            //
            Console.Clear();
            Console.SetCursorPosition(0, 0); /// 커서를 왼쪽 맨 위로 이동
            //
            // 화면출력
            ItemManager.Instance.PrintInventory();
            // 출력메뉴를 보여준다
            Console.WriteLine("1.장착 관리\n0.나가기\n"); // 
            // 입력받기
            int input = InputManager.Instance.GetValidNumber("원하시는 행동을 입력해주세요", 0, 1);
            switch (input)
            {
                case 1:
                    // 장착하기 씬으로 이동
                    SceneManager.Instance.LoadScene("equip");
                    break;
                case 0:
                    SceneManager.Instance.LoadScene("town");
                    break;
            }
        }
    }
}
