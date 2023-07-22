using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatihdgn.Notes.App.ViewModels;

public class NoteViewModel : BindableObject
{
    private Guid id;
    private string name;
    private string content;
    private DateTimeOffset createdAt;
    private bool applied;
    private bool inEditMode;

    public Guid Id { get => id; set { id = value; OnPropertyChanged(); } }
    public string Name { get => name; set { name = value; OnPropertyChanged(); } }
    public string Content { get => content; set { content = value; OnPropertyChanged(); } }
    public DateTimeOffset CreatedAt { get => createdAt; set { createdAt = value; OnPropertyChanged(); } }
    public bool Applied { get { return applied; } set { applied = value; OnPropertyChanged(); } }
    public bool InEditMode { get { return inEditMode; } set { inEditMode = value; OnPropertyChanged(); } }

    public void ApplyEntity(Note note)
    {
        if (note == null) return;
        Id = note.Id;
        Name = note.Name;
        Content = note.Content;
        CreatedAt = note.CreatedAt;
        Applied = true;
    }

    public Note AsEntity() => new Note { Id = Id, Name = Name, Content = Content, CreatedAt = CreatedAt };
}
