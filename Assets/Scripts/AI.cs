using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 敵人 AI : 決定如何移動 、 追蹤玩家 、 開槍跳躍受傷死亡
/// </summary>
public class AI : MonoBehaviour
{
    #region 欄位
    /// <summary>
    /// AI 狀態
    /// </summary>
    public StateAI state;
    #endregion

    #region 方法
    #endregion

    #region 事件
    #endregion
}

public enum StateAI
{
    Idle, RandomWalk, TrackTarget, Fire
}