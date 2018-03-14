using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    public List<BaseStat> stats { get; set; }
    public string ObjectSlug { get; set; }
    public string Description { get; set; }
    public string ActionName { get; set; }
    public string ItemName { get; set; }
    public bool ItemModifier { get; set; }

    public Item(List<BaseStat> _stats, string _ObjectSlug)
    {
        this.stats = _stats;
        this.ObjectSlug = _ObjectSlug;
    }

    public Item(List<BaseStat> _stats, string _ObjectSlug, string _Description, string _ActionName, string _ItemName, bool _ItemModifier)
    {
        this.stats = _stats;
        this.ObjectSlug = _ObjectSlug;
        this.Description = _Description;
        this.ActionName = _ActionName;
        this.ItemName = _ItemName;
        this.ItemModifier = _ItemModifier;
    }

}
